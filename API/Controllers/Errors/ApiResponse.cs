using SQLitePCL;

namespace API.Errors
{
    public class ApiResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public ApiResponse(int statuscode, string message = null)
        {
            StatusCode = statuscode;
            Message = message ?? GetDefaultMessageForStatusCode(statuscode);
        }
        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 =>"A bad request that you have made",
                401=>"Authorized,No you are not",
                404=>"Resorce was not found",
                500=>"Internal Server Server",
                _ =>null
            };
        }
    }
}