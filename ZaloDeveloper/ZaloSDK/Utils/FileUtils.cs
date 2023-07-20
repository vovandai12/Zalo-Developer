using System.Net;

namespace ZaloSDK.Utils
{
    public class FileUtils
    {
        public static byte[] loadFile(String path)
        {
            if (path.Contains("http"))
            {
                return new WebClient().DownloadData(path);
            }
            return File.ReadAllBytes(path);
        }
    }
}
