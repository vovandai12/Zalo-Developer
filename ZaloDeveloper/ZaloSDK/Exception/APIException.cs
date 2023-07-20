namespace ZaloSDK.Exception
{
    public class APIException : IOException
    {
        private int? _code { get; set; }
        private string? _url { get; set; }
        private string? _message { get; set; }

        public APIException(int code, string url, string message)
        {
            this._code = code;
            this._url = url;
            this._message = message;
        }

        public APIException(string message)
        {
            this._message = message;
        }
    }

}
