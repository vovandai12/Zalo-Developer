using Newtonsoft.Json;
using OpenQA.Selenium;
using Zalo_Tool_V1.Model;

namespace Zalo_Tool_V1.Helper
{
    public class BackupHelper
    {
        public void BackupWebDriver(IWebDriver driver)
        {
            var webDriverData = new WebDriverData
            {
                //WebDriverJson = driver.ToJson()
            };

            string json = JsonConvert.SerializeObject(webDriverData);
            File.WriteAllText("webDriverData.json", json);
        }
    }
}
