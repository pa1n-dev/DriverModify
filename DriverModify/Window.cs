using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace DriverModify
{
    public partial class Window : Form
    {
        IniFile file;
        public static object[] VideoAdapters = new object[0];
        public static object[] VideoAdaptersConfig = new object[0];

        public Window()
        {
            InitializeComponent();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            while (true)
            {
                FileConfig.Filter = "Select your driver config|*.inf";
                DialogResult result = FileConfig.ShowDialog();

                if (result == DialogResult.Cancel || result == DialogResult.Abort || result == DialogResult.No)
                {
                    Application.Exit();
                    return;
                }
                else if (result == DialogResult.OK && Path.GetExtension(FileConfig.FileName) == ".inf")
                    break;
                else
                    MessageBox.Show("Please take your config file with *.inf extension", "Warning", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            foreach (ManagementObject obj in new ManagementObjectSearcher("SELECT * FROM Win32_VideoController").Get())
            {
                Array.Resize(ref VideoAdapters, VideoAdapters.Length + 1);
                VideoAdapters[VideoAdapters.Length - 1] = obj["Name"].ToString();
            }

            foreach (string line in File.ReadAllLines(FileConfig.FileName))
            {
                if (line.StartsWith("NVIDIA_DEV."))
                {
                    Array.Resize(ref VideoAdaptersConfig, VideoAdaptersConfig.Length + 1);
                    VideoAdaptersConfig[VideoAdaptersConfig.Length - 1] = line.Replace("NVIDIA_DEV.", "").Replace('"'.ToString(), "").Replace("=", " - ");
                }
            }

            Device.Items.AddRange(Window.VideoAdapters);
            Device.SelectedItem = Device.Items[0];
            VideoAdapterConfig.Items.AddRange(Window.VideoAdaptersConfig);
            VideoAdapterConfig.SelectedItem = VideoAdapterConfig.Items[0];
        }

        private void Device_SelectedValueChanged(object sender, EventArgs e)
        {
            string text = string.Empty;
            foreach (ManagementObject obj in new ManagementObjectSearcher("select * from Win32_VideoController").Get())
            {
                if (Device.SelectedItem.ToString() == obj["Name"].ToString())
                    text += obj["PNPDeviceID"];
            }

            DeviceID.Text = text.Substring(0, 37);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Directory.GetCurrentDirectory() + "/backup/"))
                    Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/backup/");

                File.Copy(FileConfig.FileName, Directory.GetCurrentDirectory() + "/backup/" + Path.GetFileName(FileConfig.FileName), true);

                List<string> modifiedLines = new List<string>();
                string[] lines = File.ReadAllLines(FileConfig.FileName);

                foreach (string line in lines)
                {
                    if (line.StartsWith("%NVIDIA_DEV." + VideoAdapterConfig.SelectedItem.ToString().Substring(0, 14) + "%"))
                    {
                        modifiedLines.Add(line.Substring(0, 42) + DeviceID.Text);
                    }
                    else
                    {
                        modifiedLines.Add(line);
                    }
                }

                File.WriteAllLines(FileConfig.FileName, modifiedLines);

                MessageBox.Show("Modification completed! \nReboot your device in safe mode with disabled driver signature verification", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            Application.Exit();
        }
    }
}
