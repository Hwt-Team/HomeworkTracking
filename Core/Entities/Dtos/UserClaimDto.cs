using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    public class UserClaimDto : IDto
    {
        public int UserClaimId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClaimName  { get; set; }
        public bool Status { get; set; }

    }
}
