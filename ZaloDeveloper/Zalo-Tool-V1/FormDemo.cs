using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using Serilog;
using System.Net;
using SeleniumWebdriver;
using SeleniumWebdriver.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zalo_Tool_V1
{
    public partial class FormDemo : Form
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        IWebDriver driver;

        private void BtnDemo_Click(object sender, EventArgs e)
        {
            driver = SeleniumController.OpenChromeDriver(null, Path.Combine(Environment.CurrentDirectory, "Chrome\\Profile"), Path.Combine(Environment.CurrentDirectory, "Chrome\\ChromeSetup.exe"), false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleniumController.QuitChromeDriver(driver);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SeleniumController.GoToUrl(driver, @"https://id.zalo.me/account?continue=https://chat.zalo.me");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] data = ZaloController.GetQRCodeLogin(driver);
            if(data == null )
            {
                MemoryStream stream = new MemoryStream(data);
                pictureBox1.Image = Image.FromStream(stream);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeleniumController.GoToUrl(driver, @"https://chat.zalo.me/");
            Dictionary<string, string> keyValuePairs = ParseStringToDictionary(textBox1.Text.Trim());
            foreach (var item in keyValuePairs)
            {
                listBox1.Items.Add(item.Key.ToString() + "-" + keyValuePairs[item.Key.ToString()]);
                SeleniumController.AddCookie(driver, item.Key.ToString(), keyValuePairs[item.Key.ToString()]);
            }
        }

        static Dictionary<string, string> ParseStringToDictionary(string input)
        {
            var keyValuePairs = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(input))
            {
                string[] pairs = input.Split(';');
                foreach (string pair in pairs)
                {
                    string[] keyValue = pair.Trim().Split('=');
                    if (keyValue.Length == 2)
                    {
                        string key = keyValue[0].Trim();
                        string value = keyValue[1].Trim();
                        keyValuePairs[key] = value;
                    }
                }
            }
            return keyValuePairs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ZaloUserProfile zaloUserProfile = ZaloController.GetZaloUserProfile(driver);
            MemoryStream stream = new MemoryStream(zaloUserProfile.avatar);
            pictureBox1.Image = Image.FromStream(stream);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            listBox1.Items.Add(zaloUserProfile.fullName);
                listBox1.Items.Add(zaloUserProfile.phone);
            listBox1.Items.Add(zaloUserProfile.gender);
            listBox1.Items.Add(zaloUserProfile.birthDay);
        }
    }
}