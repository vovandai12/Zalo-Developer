using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.Helper;
using SeleniumWebdriver.Model;
using System.Xml.Linq;

namespace SeleniumWebdriver
{
    public class ZaloController
    {

        /// <summary>
        /// Lấy mã QRCode đăng nhập
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        public static byte[] GetQRCodeLogin(IWebDriver driver)
        {
            SeleniumController.GoToUrl(driver, BaseUrl.ZALO_LOGIN);
            List<byte[]> list = SeleniumController.GetByteImageByTagName(driver, @"img");
            if (list != null && list.Count == 1)
            {
                foreach (byte[] item in list)
                {
                    if (item != null)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static ZaloUserProfile GetZaloUserProfile(IWebDriver driver)
        {
            SeleniumController.GoToUrl(driver, BaseUrl.ZALO_ME);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            try
            {
                IWebElement element = wait.Until(driver =>
                {
                    try
                    {
                        IWebElement element = SeleniumController.FindElementByXPath(driver, @"//div[@class='rel zavatar-container clickable']");
                        return element.Displayed ? element : null;
                    }
                    catch (NoSuchElementException)
                    {
                        return null;
                    }
                });
                if (element != null)
                {
                    SeleniumController.Click(element);
                }
            }
            finally{}
            List<IWebElement> list = SeleniumController.FindAllElementByXPath(driver, @"//div[@class='truncate flx-1']");
            foreach (var item in list)
            {
                if (SeleniumController.GetTextElement(item).Equals("Hồ sơ của bạn"))
                {
                    SeleniumController.Click(item);
                    break;
                }
            }
            IWebElement elementFullName = SeleniumController.FindElementByXPath(driver, @"//div[@class='truncate friend-profile__display-name']");
            string fullName = SeleniumController.GetTextElement(elementFullName);
            IWebElement userProfile = SeleniumController.FindElementByXPath(driver, @"//div[@class='user-profile-details']");
            string phone = userProfile.FindElement(By.CssSelector("span[data-translate-inner='STR_PROFILE_PHONENUMBER'] + span")).Text;
            string gender = userProfile.FindElement(By.CssSelector("span[data-translate-inner='STR_PROFILE_LABEL_GENDER'] + span")).Text;
            string birthday = userProfile.FindElement(By.CssSelector("span[data-translate-inner='STR_PROFILE_LABEL_BIRTHDAY'] + span")).Text;

            ZaloUserProfile result = new()
            {
                fullName = fullName,
                phone = phone,
                gender = gender.Equals("Nam") ? true : false,
                birthDay = DateHelper.Convert(birthday)
            };
            return result;
        }

    }
}
