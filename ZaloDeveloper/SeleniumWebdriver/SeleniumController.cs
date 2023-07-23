using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumWebdriver.Exception;
using SeleniumWebdriver.Helper;

namespace SeleniumWebdriver
{
    public class SeleniumController
    {
        public SeleniumController() { }

        /// <summary>
        /// Mở trình duyệt
        /// </summary>
        /// <param name="sslProxy"></param>
        /// <param name="pathProfile"></param>
        /// <param name="pathChrome"></param>
        /// <param name="hidden"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebDriver OpenChromeDriver(string sslProxy, string pathProfile, string pathChrome, bool hidden = true)
        {
            try
            {
                if (String.IsNullOrEmpty(pathProfile) || String.IsNullOrEmpty(pathChrome))
                {
                    return null;
                }
                Proxy proxy = new()
                {
                    Kind = ProxyKind.Manual,
                    IsAutoDetect = false,
                    HttpProxy = sslProxy,
                    SslProxy = sslProxy
                };
                ChromeOptions options = new()
                {
                    Proxy = proxy
                };
                options.AddArgument("ignore-certificate-errors");
                options.AddArgument("--user-data-dir=" + pathProfile);
                if (hidden) options.AddArgument("--headless");
                ChromeDriverService service = ChromeDriverService.CreateDefaultService(pathChrome);
                IWebDriver driver = new ChromeDriver(service, options);
                return driver;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "OpenChromeDriver()", ex.Message);
            }
        }

        /// <summary>
        /// Đóng trình duyệt
        /// </summary>
        /// <param name="driver"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static bool QuitChromeDriver(IWebDriver driver)
        {
            try
            {
                driver.Quit();
                return true;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "QuitChromeDriver(IWebDriver driver)", ex.Message);
            }
            return false;
        }

        /// <summary>
        /// Chuyển hướng đến trang
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="url"></param>
        /// <exception cref="SeleniumException"></exception>
        public static void GoToUrl(IWebDriver driver, string url)
        {
            try
            {
                driver.Navigate().GoToUrl(url);
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GoToUrl(IWebDriver driver, string url)", ex.Message);
            }
        }

        /// <summary>
        /// Lấy List hình ảnh thông qua TagName
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<byte[]> GetByteImageByTagName(IWebDriver driver, string tagName)
        {
            try
            {
                if (String.IsNullOrEmpty(tagName)) return null;
                List<byte[]> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.TagName(tagName));
                foreach (IWebElement element in anchors)
                {
                    string imageUrl = element.GetAttribute("src");
                    byte[] imageBytes = SeleniumHelper.GetImageBytes(imageUrl);
                    if (imageBytes != null)
                    {
                        list.Add(imageBytes);
                    }
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GetByteImageByTagName(IWebDriver driver, string tagName)", ex.Message);
            }
        }

        /// <summary>
        /// Lấy hình ảnh thông qua tagname và from cha
        /// </summary>
        /// <param name="element"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static byte[] GetByteImageByFather(IWebElement element, string tagName)
        {
            try
            {
                if (String.IsNullOrEmpty(tagName)) return null;
                IWebElement anchors = element.FindElement(By.TagName(tagName));
                string imageUrl = element.GetAttribute("src");
                byte[] imageBytes = SeleniumHelper.GetImageBytes(imageUrl);
                return imageBytes;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GetByteImageByFather(IWebElement element, string tagName)", ex.Message);
            }
        }

        /// <summary>
        /// Thêm cookie vào trình duyệt
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="SeleniumException"></exception>
        public static void AddCookie(IWebDriver driver, string key, string value)
        {
            try
            {
                driver.Manage().Cookies.DeleteCookieNamed("key");
                Cookie cookie = new Cookie("key", "value");
                driver.Manage().Cookies.AddCookie(cookie);
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "AddCookie(IWebDriver driver, string key, string value)", ex.Message);
            }
        }

        /// <summary>
        /// Xoá tất cả cookie
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="url"></param>
        /// <exception cref="SeleniumException"></exception>
        public static void DeleteAddCookie(IWebDriver driver, string url)
        {
            try
            {
                GoToUrl(driver, url);
                driver.Manage().Cookies.DeleteAllCookies();
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "DeleteAddCookie(IWebDriver driver, string url)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo Id
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementById(IWebDriver driver, string id)
        {
            try
            {
                if (string.IsNullOrEmpty(id)) return null;
                IWebElement element = driver.FindElement(By.Id(id));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementById(IWebDriver driver, string id)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo ClassName
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByClassName(IWebDriver driver, string className)
        {
            try
            {
                if (string.IsNullOrEmpty(className)) return null;
                IWebElement element = driver.FindElement(By.ClassName(className));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByClassName(IWebDriver driver, string className)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo CssSelector
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByCssSelector(IWebDriver driver, string cssSelector)
        {
            try
            {
                if (string.IsNullOrEmpty(cssSelector)) return null;
                IWebElement element = driver.FindElement(By.CssSelector(cssSelector));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByCssSelector(IWebDriver driver, string cssSelector)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo LinkText
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="linkText"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByLinkText(IWebDriver driver, string linkText)
        {
            try
            {
                if (string.IsNullOrEmpty(linkText)) return null;
                IWebElement element = driver.FindElement(By.LinkText(linkText));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByLinkText(IWebDriver driver, string linkText)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo Name
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByName(IWebDriver driver, string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name)) return null;
                IWebElement element = driver.FindElement(By.Name(name));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByName(IWebDriver driver, string name)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo PartialLinkText
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="pText"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByPartialLinkText(IWebDriver driver, string pText)
        {
            try
            {
                if (string.IsNullOrEmpty(pText)) return null;
                IWebElement element = driver.FindElement(By.PartialLinkText(pText));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByPartialLinkText(IWebDriver driver, string pText)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo TagName
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByTagName(IWebDriver driver, string tagName)
        {
            try
            {
                if (string.IsNullOrEmpty(tagName)) return null;
                IWebElement element = driver.FindElement(By.TagName(tagName));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByTagName(IWebDriver driver, string tagName)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm element theo Xpath
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="xPath"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IWebElement FindElementByXPath(IWebDriver driver, string xPath)
        {
            try
            {
                if (string.IsNullOrEmpty(xPath)) return null;
                IWebElement element = driver.FindElement(By.XPath(xPath));
                return element;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindElementByXPath(IWebDriver driver, string xPath)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo id
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementById(IWebDriver driver, string id)
        {
            try
            {
                if (String.IsNullOrEmpty(id)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.Id(id));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementById(IWebDriver driver, string id)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo ClassName
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="className"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByClassName(IWebDriver driver, string className)
        {
            try
            {
                if (String.IsNullOrEmpty(className)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.ClassName(className));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByClassName(IWebDriver driver, string className)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo CssSelector
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByCssSelector(IWebDriver driver, string cssSelector)
        {
            try
            {
                if (String.IsNullOrEmpty(cssSelector)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.CssSelector(cssSelector));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByCssSelector(IWebDriver driver, string cssSelector)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm IReadOnlyCollection element theo CssSelector
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="cssSelector"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IReadOnlyCollection<IWebElement> FindAllIReadOnlyCollectionElementByCssSelector(IWebDriver driver, string cssSelector)
        {
            try
            {
                if (String.IsNullOrEmpty(cssSelector)) return null;
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.CssSelector(cssSelector));
                return anchors;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllIReadOnlyCollectionElementByCssSelector(IWebDriver driver, string cssSelector)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo LinkText
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="linkText"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByLinkText(IWebDriver driver, string linkText)
        {
            try
            {
                if (String.IsNullOrEmpty(linkText)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.LinkText(linkText));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByLinkText(IWebDriver driver, string linkText)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo Name
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByName(IWebDriver driver, string name)
        {
            try
            {
                if (String.IsNullOrEmpty(name)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.Name(name));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByName(IWebDriver driver, string name)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo PartialLinkText
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="pText"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByPartialLinkText(IWebDriver driver, string pText)
        {
            try
            {
                if (String.IsNullOrEmpty(pText)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.PartialLinkText(pText));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByPartialLinkText(IWebDriver driver, string pText)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo TagName
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByTagName(IWebDriver driver, string tagName)
        {
            try
            {
                if (String.IsNullOrEmpty(tagName)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.TagName(tagName));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByTagName(IWebDriver driver, string tagName)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm list element theo Xpath
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="xPath"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<IWebElement> FindAllElementByXPath(IWebDriver driver, string xPath)
        {
            try
            {
                if (String.IsNullOrEmpty(xPath)) return null;
                List<IWebElement> list = new();
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.XPath(xPath));
                foreach (IWebElement element in anchors)
                {
                    list.Add(element);
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllElementByXPath(IWebDriver driver, string xPath)", ex.Message);
            }
        }

        /// <summary>
        /// Tìm kiếm IReadOnlyCollection Element theo Xpath
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="xPath"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static IReadOnlyCollection<IWebElement> FindAllIReadOnlyCollectionElementByXPath(IWebDriver driver, string xPath)
        {
            try
            {
                if (String.IsNullOrEmpty(xPath)) return null;
                IReadOnlyCollection<IWebElement> anchors = driver.FindElements(By.XPath(xPath));
                return anchors;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "FindAllIReadOnlyCollectionElementByXPath(IWebDriver driver, string xPath)", ex.Message);
            }
        }

        /// <summary>
        /// Click vào phần tử
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static bool Click(IWebElement element)
        {
            try
            {
                element.Click();
                return true;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "Click(IWebElement element)", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Lấy giá trị text element
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static string GetTextElement(IWebElement element)
        {
            try
            {
                return element.Text;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GetTextElement(IWebElement element)", ex.Message);
            }
        }

        /// <summary>
        /// Lấy tất cả giá trị các tagName con trong element cha
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="elementFarther"></param>
        /// <param name="tagName"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static List<String> GetTextByFartherAndSon(IWebDriver driver, IReadOnlyCollection<IWebElement> elementFarther, string tagName)
        {
            try
            {
                List<String> list = new();
                if (elementFarther.Count > 0 && String.IsNullOrEmpty(tagName))
                {
                    foreach (var item in elementFarther)
                    {
                        list.Add(item.FindElement(By.TagName(tagName)).Text);
                    }
                }
                return list;
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GetTextByFartherAndSon(IWebDriver driver, List<IWebElement> elementFarther, string tagName)", ex.Message);
            }
        }

    }
}