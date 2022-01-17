using _77Diamonds.ViewModel;

namespace _77Diamonds.API.Model
{
    public class AuthenticateResponse
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
        public UserViewModel User { get; set; }


        public AuthenticateResponse(UserViewModel user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Email = user.Email;
            Success = false;
            Token = token;
            User = user;
        }


    }
}
