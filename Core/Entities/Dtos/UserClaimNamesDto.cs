using Core.Entities.Abstract;

namespace Core.Entities.Dtos
{
    public class UserClaimNamesDto : IDto
    {
        public int UserClaimId { get; set; }
        public string ClaimName { get; set; }
    }
}
