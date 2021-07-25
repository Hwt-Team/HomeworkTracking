using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class UserLoginDto : IDto
    {
        public string EmailOrUsername { get; set; }
        public string Password { get; set; }
    }
}
