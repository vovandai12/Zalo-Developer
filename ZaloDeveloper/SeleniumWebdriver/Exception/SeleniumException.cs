namespace SeleniumWebdriver.Exception
{
    public class SeleniumException : IOException
    {
        private int? _code { get; set; }
        private string? _func { get; set; }
        private string? _message { get; set; }
        public SeleniumException() { }
        public SeleniumException(int code, string func, string message) {
            this._func = func;
            this._code = code;
            this._message = message;
        }
    }
}
