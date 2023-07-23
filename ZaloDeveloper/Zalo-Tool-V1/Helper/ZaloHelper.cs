using OpenQA.Selenium;
using SeleniumWebdriver;

namespace Zalo_Tool_V1.Helper
{
    public class ZaloHelper
    {

        private string ChromeProfile = Path.Combine(Environment.CurrentDirectory, "Chrome\\Profile");
        private string ChomeExe = Path.Combine(Environment.CurrentDirectory, "Chrome\\ChromeSetup.exe");

        public IWebDriver OpenChrome(string sslProxy = null)
        {
            IWebDriver driver = SeleniumController.OpenChromeDriver(sslProxy, ChromeProfile, ChomeExe, false);
            return driver;
        }
    }
}
