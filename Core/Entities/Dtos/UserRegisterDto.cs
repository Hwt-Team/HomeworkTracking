using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    public class UserRegisterDto : IDto
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
