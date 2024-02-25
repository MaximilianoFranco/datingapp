namespace API.Errors
{
    public class ApiException
    {
        public ApiException(int code, string message, string errorMessage = null){
            StatusCode = code;
            Message = message;
            ErrorMessage = errorMessage;
        }
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }
}