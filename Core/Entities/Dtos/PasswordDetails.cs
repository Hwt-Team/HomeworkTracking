using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    public class PasswordDetails : IDto
    {
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
