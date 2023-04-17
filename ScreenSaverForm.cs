using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarSrc
{
    public partial class ScreenSaverForm : Form
    {
        private void SetText2PB(int value, ProgressBar pb)
        {
            if (pb.InvokeRequired)
            {
                SetValueCallBack svcb = new SetValueCallBack(SetText2PB);
                Invoke(svcb, new object[] { value });
            }
            else pb.Value = value;
        }

        delegate void SetValueCallBack(int value, ProgressBar pb);

        private int maxProgressBarWidth = 300;
        private int minProgressBarWidth = 50;
        private int maxProgressBarHeight = 40;
        private int minProgressBarHeight = 10;
        private int maxMoveSpeed = 5;
        private int minMoveSpeed = 1;
        private int ProgressBarCount = 20;
        private int maxProgressIncrement = 10;
        private int minProgressIncrement = 0;

        private Random random = new Random();

        public ScreenSaverForm()
        {
            InitializeComponent();

            // 隐藏窗体边框
            FormBorderStyle = FormBorderStyle.None;

            // 设置窗体全屏
            Bounds = Screen.PrimaryScreen.Bounds;

            // 将窗体背景设置为黑色
            BackColor = Color.Black;
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            string iniFilePath = Path.Combine(Application.StartupPath, "PrpBarScrsettings.ini");

            if (File.Exists(iniFilePath))
            {
                Program.FilesINI iniFile = new Program.FilesINI(iniFilePath);

                string background = iniFile.Read("Background", "Settings");
                if (background.ToLower() == "light") BackColor = Color.White;
                else if (background.ToLower() == "dark") BackColor = Color.Black;
                else if (!string.IsNullOrEmpty(background)) MessageBox.Show(
                    "\"" + background + "\" is not a valid value for Background");

                maxProgressBarWidth = iniFile.ReadInteger("MaxProgressBarWidth", "Settings", maxProgressBarWidth);
                minProgressBarWidth = iniFile.ReadInteger("MinProgressBarWidth", "Settings", minProgressBarWidth);
                maxProgressBarHeight = iniFile.ReadInteger("MaxProgressBarHeight", "Settings", maxProgressBarHeight);
                minProgressBarHeight = iniFile.ReadInteger("MinProgressBarHeight", "Settings", minProgressBarHeight);
                maxMoveSpeed = iniFile.ReadInteger("MaxMoveSpeed", "Settings", maxMoveSpeed);
                minMoveSpeed = iniFile.ReadInteger("MinMoveSpeed", "Settings", minMoveSpeed);
                maxProgressIncrement = iniFile.ReadInteger("MaxProgressIncrement", "Settings", maxProgressIncrement);
                minProgressIncrement = iniFile.ReadInteger("MinProgressIncrement", "Settings", maxProgressIncrement);
                ProgressBarCount = iniFile.ReadInteger("ProgressBarCount", "Settings", ProgressBarCount);
            }
            Cursor.Hide();
            for (int i = 0; i < ProgressBarCount; i++)
            {
                ProgressBar pb = new ProgressBar();
                pb.Name = i.ToString();
                pb.Tag = new int[] {
                    random.Next(minMoveSpeed, maxMoveSpeed + 1), //Move speed
                    random.Next(0,ProgressBarCount*100+1), //Delay time
                    0, //Current passed time
                };
                Controls.Add(pb);
                Timer timer = new Timer();
                timer.Interval = 10;
                Timer timer2 = new Timer();
                timer2.Interval = 1000;
                timer2.Tag = timer;
                timer2.Tick += UpdateValue;
                timer.Tag = new object[] { pb, timer2 };
                timer.Tick += Update;
                timer.Start();
                timer2.Start();
                pb.Size = new Size(random.Next(minProgressBarWidth, maxProgressBarWidth + 1), random.Next(minProgressBarHeight, maxProgressBarHeight + 1));
                pb.Location = new Point(-pb.Width, random.Next(0, Height - pb.Height + 1));
            }
        }

        private void Update(object sender, EventArgs e)
        {
            ProgressBar pb = ((sender as Timer).Tag as object[])[0] as ProgressBar;
            int[] tags = pb.Tag as int[];
            if (tags[1] <= tags[2]) //Make delay
            {
                pb.Location = new Point(pb.Location.X + tags[0], pb.Location.Y);
                if (pb.Location.X > Width + pb.Width)
                {
                    pb.Size = new Size(random.Next(minProgressBarWidth, maxProgressBarWidth), random.Next(minProgressBarHeight, maxProgressBarHeight + 1));
                    pb.Location = new Point(-pb.Width, random.Next(0, Height - pb.Height));
                }
            }
            else tags[2]++;
            pb.Tag = tags;
        }

        private void UpdateValue(object sender, EventArgs e)
        {
            ProgressBar pb = (((sender as Timer).Tag as Timer).Tag as object[])[0] as ProgressBar;
            if (pb.Value <= 100)
            {
                int ProgressIncrement = random.Next(minProgressIncrement, maxProgressIncrement + 1);
                while (pb.Value + ProgressIncrement > 100) ProgressIncrement--;
                pb.Value += ProgressIncrement;
            }
        }
    }
}