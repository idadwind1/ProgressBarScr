using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ProgressBarSrc
{
    internal static class Program
    {

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr handle);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*foreach (var item in args)
            {
                MessageBox.Show(item);
            }*/
            if (args.Length != 0)
            {
                switch (args[0].ToUpper())
                {
                    case "-S":
                    case "/S":
                        Application.Run(new ScreenSaverForm());
                        return;
                    case "-P":
                    case "/P":
                        if (args.Length < 2) return;
                        if (!int.TryParse(args[1], out int result)) return;
                        IntPtr handle = new IntPtr(result);
                        Application.Run(new ScreenSaverForm(handle));
                        return;
                }
                if (!args[0].ToUpper().StartsWith("/C")) return;
            }
            Application.Run(new Settings());
        }


        public class FilesINI
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



            public string Read(string key, string section, string Default)
            {
                StringBuilder temp = new StringBuilder(255);
                GetPrivateProfileString(section, key, Default, temp, 255, path);
                return temp.ToString();
            }

            public int ReadInteger(string key, string section, int Default)
            {
                string str = Read(key, section);
                try
                { return int.Parse(str); }
                catch
                {
                    if (!string.IsNullOrEmpty(str) && str.ToLower() != "default") MessageBox.Show("\"" + str + "\" is not a valid integer for " + key, "Error");
                    return Default;
                }
            }
            public double ReadDouble(string key, string section, double Default)
            {
                string str = Read(key, section);
                try
                { return double.Parse(str); }
                catch
                {
                    if (!string.IsNullOrEmpty(str) && str.ToLower() != "default") MessageBox.Show("\"" + str + "\" is not a valid value for " + key, "Error");
                    return Default;
                }
            }
        }

    }
}
