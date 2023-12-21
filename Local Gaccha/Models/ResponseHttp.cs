namespace Local_Gaccha.Models
{
    public class ResponseHttp
    {

        public ResponseHttp(bool success, string message = "", object? data = null)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public object? Data { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
