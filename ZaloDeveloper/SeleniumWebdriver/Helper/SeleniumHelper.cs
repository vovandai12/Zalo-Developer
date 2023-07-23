using SeleniumWebdriver.Exception;

namespace SeleniumWebdriver.Helper
{
    public class SeleniumHelper
    {
        /// <summary>
        /// Tải nội dung hình ảnh và chuyển thành dữ liệu byte[]
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <returns></returns>
        /// <exception cref="SeleniumException"></exception>
        public static byte[] GetImageBytes(string imageUrl)
        {
            try
            {
                if (!imageUrl.Contains("data"))
                {
                    HttpClient httpClient = new HttpClient();
                    HttpResponseMessage response = httpClient.GetAsync(imageUrl).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsByteArrayAsync().Result;
                    }
                }
                else
                {
                    if (imageUrl.StartsWith("data:"))
                    {
                        string[] parts = imageUrl.Split(',');
                        if (parts.Length != 2)
                        {
                            return null;
                        }
                        string imageData = parts[1];
                        byte[] imageBytes = Convert.FromBase64String(imageData);
                        return imageBytes;
                    }
                }
                
            }
            catch (IOException ex)
            {
                throw new SeleniumException(ex.GetHashCode(), "GetImageBytes(string imageUrl)", ex.Message);
            }
            return null;
        }
    }
}
