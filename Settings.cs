using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProgressBarSrc
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            Background.SelectedIndex = 0;
            demoProcess.StartInfo.FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            demoProcess.StartInfo.Arguments = "/P " + panel1.Handle.ToInt32().ToString();
        }

        System.Diagnostics.Process demoProcess = new System.Diagnostics.Process();

        private void button2_Click(object sender, EventArgs e)
        { Close(); }

        private void Settings_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Black;
            string background = ini.Read("Background", "Settings");
            if (background.ToLower() == "light") Background.SelectedIndex = 1;
            else if (background.ToLower() == "dark") Background.SelectedIndex = 0;
            MinWidth.Value = ini.ReadInteger("MinProgressBarWidth", "Settings", (int)MinWidth.Value);
            MaxWidth.Value = ini.ReadInteger("MaxProgressBarWidth", "Settings", (int)MaxWidth.Value);
            MinHeight.Value = ini.ReadInteger("MinProgressBarHeight", "Settings", (int)MinHeight.Value);
            MaxHeight.Value = ini.ReadInteger("MaxProgressBarHeight", "Settings", (int)MaxHeight.Value);
            MinSpeed.Value = ini.ReadInteger("MinMoveSpeed", "Settings", (int)MinSpeed.Value);
            MaxSpeed.Value = ini.ReadInteger("MaxMoveSpeed", "Settings", (int)MaxSpeed.Value);
            MinIncre.Value = ini.ReadInteger("MinProgressIncrement", "Settings", (int)MinIncre.Value);
            MaxIncre.Value = ini.ReadInteger("MaxProgressIncrement", "Settings", (int)MaxIncre.Value);
            ProBarCnt.Value = ini.ReadInteger("ProgressBarCount", "Settings", (int)ProBarCnt.Value);
            Background.SelectedIndexChanged += new EventHandler(ValueChanged);
            MaxHeight.ValueChanged += new EventHandler(ValueChanged);
            MinHeight.ValueChanged += new EventHandler(ValueChanged);
            MaxWidth.ValueChanged += new EventHandler(ValueChanged);
            MinWidth.ValueChanged += new EventHandler(ValueChanged);
            MaxIncre.ValueChanged += new EventHandler(ValueChanged);
            MaxSpeed.ValueChanged += new EventHandler(ValueChanged);
            MinSpeed.ValueChanged += new EventHandler(ValueChanged);
            ProBarCnt.ValueChanged += new EventHandler(ValueChanged);
            demoProcess.Start();
            ValueChanged(sender, e);
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            if ((sender as Control) != TabControl && !(sender is Settings))
            {
                ApplyChanges.Enabled = true;
                Discard.Text = "Discard";
                label13.Text = "Demo (Click confirm to update):";
            }
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    label6.Text = string.Format("The size of the progress bar will be minimum ({0},{1}) and maximum ({2},{3}). Your screen resolution is ({4},{5})",
                        MinWidth.Value.ToString(), MinHeight.Value.ToString(), 
                        MaxWidth.Value.ToString(), MaxHeight.Value.ToString(),
                        Screen.GetBounds(this).Width, Screen.GetBounds(this).Height);
                    break;
                case 1:
                    label6.Text = string.Format("The speed of the progress bar will be minimum {0} pixel per 10ms and maximum {1} pixel per 10ms. The slowest and longest progress bar will need {2:0.00}s to the destination. The progress of the progress bar will minimum increase {3}% per 10ms and maximum increase {4}% per 10ms",
                        MinSpeed.Value.ToString(), MaxSpeed.Value.ToString(), (Screen.GetBounds(this).Width + MaxWidth.Value) / MaxSpeed.Value / 100, MinIncre.Value, MaxIncre.Value);
                    break;
                case 2:
                    label6.Text = string.Format("The color of the background will be {0}", Background.Text);
                    break;
                case 3:
                    label6.Text = string.Format("The program will generate {0} progress bar{1}", ProBarCnt.Value, (ProBarCnt.Value == 1 ? "" : "s"));
                    break;
                case 4:
                    label6.Text = "More function";
                    break;
            }
            ControlEnter(sender, e);
        }

        private void ControlEnter(object sender, EventArgs e)
        {
            switch ((sender as Control).Name)
            {
                case "TabControl":
                    label19.Text = "Please choose tab";
                    break;
                case "MinWidth":
                    label19.Text = "Minimum width of the progress bar (unit: pixel)";
                    break;
                case "MaxWidth":
                    label19.Text = "Maximum width of the progress bar (unit: pixel)";
                    break;
                case "MinHeight":
                    label19.Text = "Minimum height of the progress bar (unit: pixel)";
                    break;
                case "MaxHeight":
                    label19.Text = "Maximum height of the progress bar (unit: pixel)";
                    break;
                case "MinSpeed":
                    label19.Text = string.Format("Progress bar will minimum move {0} per 10ms. The fastest and shortest progress bar will need {1:0.00}s to the destination", MinSpeed.Value, (Screen.GetBounds(this).Width + MinWidth.Value) / MinSpeed.Value / 100);
                    break;
                case "MaxSpeed":
                    label19.Text = string.Format("Progress bar will maximum move {0} per 10ms. The slowest and longest progress bar will need {1:0.00}s to the destination", MaxSpeed.Value, (Screen.GetBounds(this).Width + MaxWidth.Value) / MaxSpeed.Value / 100);
                    break;
                case "MinIncre":
                    label19.Text = string.Format("Progress of progress bar will minimum increase {0}% per 10ms.", MinIncre.Value);
                    break;
                case "MaxIncre":
                    label19.Text = string.Format("Progress of progress bar will maximum increase {0}% per 10ms.", MaxIncre.Value);
                    break;
                case "ProBarCnt":
                    label19.Text = "Count of the progress bar";
                    break;
                case "Background":
                    label19.Text = "Background color of the window";
                    break;
                case "ApplyChanges":
                    label19.Text = "Apply all changes, settings will be saved to ProBarScrSettings.ini";
                    break;
                case "Discard":
                    label19.Text = "Discard all changes and exit";
                    break;
                case "Reset":
                    label19.Text = "Reset all settings to default";
                    break;
                case "Start":
                    label19.Text = string.Format("Start a demo view of screen saver, command line: \"{0}\"", System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName + " /S");
                    break;
                default:
                    label19.Text = "";
                    break;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = ApplyChanges.Enabled && MessageBox.Show("Are you sure to discard all the changes?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No;
        }

        Program.FilesINI ini = new Program.FilesINI(Path.Combine(Application.StartupPath, "ProBarScrSettings.ini"));
        private void ApplyChanges_Click(object sender, EventArgs e)
        {
            if (!demoProcess.HasExited) demoProcess.Kill();
            demoProcess.Start();
            ini.Write("MinProgressBarWidth", "Settings", MinWidth.Value.ToString());
            ini.Write("MaxProgressBarWidth", "Settings", MaxWidth.Value.ToString());
            ini.Write("MinProgressBarHeight", "Settings", MinHeight.Value.ToString());
            ini.Write("MaxProgressBarHeight", "Settings", MaxHeight.Value.ToString());
            ini.Write("MinMoveSpeed", "Settings", MinSpeed.Value.ToString());
            ini.Write("MaxMoveSpeed", "Settings", MaxSpeed.Value.ToString());
            ini.Write("MinProgressIncrement", "Settings", MinIncre.Value.ToString());
            ini.Write("MaxProgressIncrement", "Settings", MaxIncre.Value.ToString());
            ini.Write("ProgressBarCount", "Settings", ProBarCnt.Value.ToString());
            ini.Write("Background", "Settings", Background.Text);
            ApplyChanges.Enabled = false;
            label13.Text = "Demo:";
            Discard.Text = "Cancel";
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to reset all the settings?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.No) return;
            FileInfo f = new FileInfo(Path.Combine(Application.StartupPath, "ProBarScrSettings.ini"));
            if (f.Exists) f.Delete();
            Hide();
            Settings form = new Settings();
            form.ShowDialog();
            Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            p.StartInfo.Arguments = "/S";
            p.Start();
        }
    }
}