using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
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
        private int maxProgressValue = 100;
        private int minProgressValue = 0;
        private int ProgressBarCount = 20;
        private int maxProgressIncrement = 1;
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

        class FilesINI
        {
            string path;
            public FilesINI(string path)
            { this.path = path; }
            [DllImport("kernel32")]
            private static extern long WritePrivateProfileString(string section, string key,
                string val, string filePath);

            [DllImport("kernel32")]
            private static extern int GetPrivateProfileString(string section, string key, string def,
                StringBuilder retVal, int size, string filePath);

            public void Write(string key, string section, string value)
            {
                WritePrivateProfileString(section, key, value, path);
            }

            public string Read(string key, string section)
            {
                StringBuilder temp = new StringBuilder(255);
                GetPrivateProfileString(section, key, "", temp, 255, path);
                return temp.ToString();

            }

            public int ReadInteger(string key, string section, int Default)
            {
                string str = Read(key, section);
                try
                { return int.Parse(str); }
                catch
                {
                    if (!string.IsNullOrEmpty(str) && str.ToLower() != "default") MessageBox.Show("\"" + str + "\" is not a valid integer for " + key);
                    return Default;
                }
            }
        }

        private void ScreenSaverForm_Load(object sender, EventArgs e)
        {
            string iniFilePath = Path.Combine(Application.StartupPath, "settings.ini");

            if (File.Exists(iniFilePath))
            {
                FilesINI iniFile = new FilesINI(iniFilePath);

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
                maxProgressValue = iniFile.ReadInteger("MaxProgressValue", "Settings", maxProgressValue);
                minProgressValue = iniFile.ReadInteger("MinProgressValue", "Settings", maxProgressValue);
                maxProgressIncrement = iniFile.ReadInteger("MaxProgressIncrement", "Settings", maxProgressIncrement);
                minProgressIncrement = iniFile.ReadInteger("MinProgressIncrement", "Settings", maxProgressIncrement);
                ProgressBarCount = iniFile.ReadInteger("ProgressBarCount", "Settings", ProgressBarCount);
            }
            Cursor.Hide();
            for (int i = 0; i < ProgressBarCount; i++)
            {
                ProgressBar pb = new ProgressBar();
                pb.Name = i.ToString();
                pb.Tag = random.Next(minMoveSpeed, maxMoveSpeed);
                Controls.Add(pb);
                Timer timer = new Timer();
                timer.Interval = 10;
                timer.Tag = pb;
                timer.Tick += Update;
                timer.Start();
                
                //pb.Size = new Size(random.Next(minProgressBarWidth, maxProgressBarWidth), random.Next(minProgressBarHeight, maxProgressBarHeight));
                
                pb.Location = new Point(-pb.Width, random.Next(0, Height - pb.Height));
            }
        }

        private void Update(object sender, EventArgs e)
        {
            ProgressBar pb = (sender as Timer).Tag as ProgressBar;
            int tag = (int)pb.Tag;
            pb.Location = new Point(pb.Location.X + tag, pb.Location.Y);
            if (pb.Value != 100) pb.Value += random.Next(minProgressIncrement,maxProgressIncrement);
        }
    }
}