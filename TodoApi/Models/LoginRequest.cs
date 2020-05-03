namespace TodoApi.Models
{
    public class LoginRequest
    {
        public string DocumentID { get; set; }
        public string Code { get; set; }
        public string Password { get; set; }
    }
}