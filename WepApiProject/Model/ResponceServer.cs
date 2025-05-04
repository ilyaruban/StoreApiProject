using System.Net;

namespace WepApiProject.Model
{
    public class ResponceServer
    {
        public ResponceServer()
        {
            this.IsSuccess = true;
            this.ErrorMessages = new List<string>();
        }
        public bool IsSuccess {  get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> ErrorMessages { get; set; }
        public object Result {  get; set; }
    }
}
