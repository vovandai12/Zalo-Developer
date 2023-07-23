using Serilog;
using System.Xml.Linq;
using System;
using AdvancedSharpAdbClient;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LDPlayerAndADB
{
    public class ADBClientController
    {
        public static void ClearTextElement(DeviceData deviceData, AdbClient adbClient, string xpath, int charCount)
        {
            try
            {
                ClickElement(deviceData, adbClient, xpath, 30);
                adbClient.ClearInput(deviceData, charCount);
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} InputElement " + xpath + "||" + charCount + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }
        }
        public static void ClickElement(DeviceData deviceData, AdbClient adbClient, string xpath, int timeout)
        {
            try
            {
                var element = FindElement(deviceData, adbClient, xpath, timeout);
                if (element.Y == 0 && element.X == 0)
                {
                    Log.Information("Device {0} ClickElement " + xpath + ".", deviceData.Serial);
                }
                adbClient.Click(deviceData, element);
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }
        }
        public static bool ElementIsExist(DeviceData deviceData, AdbClient adbClient, string xpath, int timeout)
        {
            bool result = false;
            try
            {
                Element element = adbClient.FindElement(deviceData, "//node[@" + xpath + "]", TimeSpan.FromSeconds(timeout));
                if (element != null)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} ElemantIsExist " + xpath + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }
            return result;
        }

        public static Cords FindElement(DeviceData deviceData, AdbClient adbClient, string xpath, int timeout)
        {
            Cords result = new Cords();
            try
            {
                Element element = adbClient.FindElement(deviceData, "//node[@" + xpath + "]", TimeSpan.FromSeconds(timeout));
                if (element != null)
                {
                    result = element.Cords;
                }
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} FindElement " + xpath + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }
            return result;
        }

        public static bool FindElementAndClickCondition(DeviceData deviceData, AdbClient adbClient, string xpath, string condition, int timeout = 10)
        {
            bool result = false;
            try
            {
                var findElements = adbClient.FindElements(deviceData, "//node[@" + xpath + "]", TimeSpan.FromSeconds(timeout));
                if (findElements == null)
                {
                    return result;
                }
                foreach (var element in findElements)
                {
                    adbClient.Click(deviceData, element.Cords);
                    if (ElementIsExist(deviceData, adbClient, "//node[@" + condition + "]", 10) == true)
                    {
                        result = true;
                        return result;
                    }
                    else
                    {
                        adbClient.BackBtn(deviceData);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
            }

            return result;
        }

        public static async void InputElement(DeviceData deviceData, AdbClient adbClient, string xpath, string text)
        {
            try
            {
                ClickElement(deviceData, adbClient, xpath, 30);
                await Task.Delay(2000);
                adbClient.SendText(deviceData, text);
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} InputElement " + xpath + "||" + text + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }
        }

        public static void SwipeElement(DeviceData deviceData, AdbClient adbClient, string xpathFirst, int xpathSecond, int timeout)
        {
            try
            {
                var s1 = ElementIsExist(deviceData, adbClient, xpathFirst, timeout);
                var s2 = ElementIsExist(deviceData, adbClient, xpathFirst, timeout);
                if (s1 == true && s2 == true)
                {
                    var start = adbClient.FindElement(deviceData, "//node[@" + xpathFirst + "]", TimeSpan.FromSeconds(timeout));
                    var end = adbClient.FindElement(deviceData, "//node[@" + xpathSecond + "]", TimeSpan.FromSeconds(timeout));
                }
                else
                {
                    Log.Information("Device {0} SwipeElement " + xpathFirst + "||" + xpathSecond + "||", deviceData.Serial);
                }
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} SwipeElement " + xpathFirst + "||" + xpathSecond + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }

        }
        public static List<Element> FindElements(DeviceData deviceData, AdbClient adbClient, string xpath, int timeout)
        {
            List<Element> result = new List<Element>();
            try
            {
                Element[] elements = (Element[])adbClient.FindElements(deviceData, "//node[@" + xpath + "]", TimeSpan.FromSeconds(timeout));
                foreach (Element element in elements)
                {
                    result.Add(element);
                }
            }
            catch (Exception ex)
            {
                Log.Information("Device {0} FindElement " + xpath + "||", deviceData.Serial);
                Log.Error("Device {0} || {1} {2} ", deviceData.Serial, ex, ex.Message);
            }
            return result;
        }
    }
}