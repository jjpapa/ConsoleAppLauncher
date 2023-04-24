using System;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
//using System.Security.Cryptography;

namespace SlavaGu.ConsoleAppLauncher.Samples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            labelVer.Text = SysInfo.GetWindowsVersion();
        }

        private void buttonGetIpAddress_Click(object sender, EventArgs e)
        {
            labelIpAddress.Text = SysInfo.GetIpAddress();
        }

        private void buttonPing_Click(object sender, EventArgs e)
        {
            SysInfo.PingUrl("google.com", reply => BeginInvoke((MethodInvoker)delegate { labelPing.Text = reply; }));
        }

        private void buttonSkype_Click(object sender, EventArgs e)
        {
            labelSkype.Text = SysInfo.GetFirewallRule("Skype");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //labelRClone.Text = SysInfo.RClone("version");
            //var cmdLine = string.Format("copy {0} :hdfs:{1} --hdfs-namenode {2} --hdfs-username {3}", "C:\\Users\\User\\Downloads\\BizboxAlpha_PC_Messenger_client.zip", "/root/aaaa/DumpStack.log", "localhost:8020", "root");
            var cmdLine = string.Format("copy {0} :hdfs:{1} --log-level ERROR --hdfs-namenode {2} --hdfs-username {3}", "D:\\dev\\stable_diffusion\\sample.dat", "/user/ec2-user", "amazone-master:8088", "ec2-user");

            //var app = new ConsoleApp("rclone.exe", cmdLine);
            SysInfo.RCloneA(cmdLine, reply => BeginInvoke((MethodInvoker)delegate { Console.WriteLine(reply); }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.BlockSize = 128;
                rijndael.KeySize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;
                rijndael.Key = Encoding.UTF8.GetBytes("HHYFPTEPRBRICKS0");
                rijndael.IV = new byte[128/8];

                Console.WriteLine(Encoding.UTF8.GetString(rijndael.Key));

                using (ICryptoTransform encryptor = rijndael.CreateEncryptor())
                {
                    byte[] data = Encoding.UTF8.GetBytes(textBox1.Text);
                    textBox2.Text = Convert.ToBase64String(encryptor.TransformFinalBlock(data, 0, data.Length));
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (RijndaelManaged rijndael = new RijndaelManaged())
            {
                rijndael.BlockSize = 128;
                rijndael.KeySize = 128;
                rijndael.Mode = CipherMode.CBC;
                rijndael.Padding = PaddingMode.PKCS7;
                rijndael.Key = Encoding.UTF8.GetBytes("HHYFPTEPRBRICKS0"); ;// new byte[128 / 8];
                rijndael.IV = new byte[128 / 8];

                using (ICryptoTransform decryptor = rijndael.CreateDecryptor())
                {
                    byte[] data = Convert.FromBase64String(textBox2.Text);
                    textBox1.Text = Encoding.UTF8.GetString(decryptor.TransformFinalBlock(data, 0, data.Length));
                }
            }
        }
    }
}
