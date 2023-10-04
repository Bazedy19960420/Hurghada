using System.Net;

namespace Hurghada.Core.Bases
{
    public class Response<T>
    {
        #region Fields
        public HttpStatusCode StatusCode { get; set; }
        public object Meta { get; set; } = new object();

        public bool Succeeded { get; set; }
        public string Message { get; set; } = string.Empty;
        public List<string> Errors { get; set; } = new List<string>();
        public T Data { get; set; } = default!;
        #endregion
        #region Constructors
        public Response()
        {

        }
        public Response(T data, string message = "")
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }
        public Response(string message)
        {
            Succeeded = false;
            Message = message;
        }
        public Response(string message, bool succeeded)
        {
            Succeeded = succeeded;
            Message = message;
        }
        #endregion



    }
}
