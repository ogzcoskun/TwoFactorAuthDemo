namespace Services.Auth.GoogleAuth.Api.Models
{
    public class RegisterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
