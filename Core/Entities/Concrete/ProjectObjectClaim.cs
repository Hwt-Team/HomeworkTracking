using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class ProjectObjectClaim : IEntity
    {
        public int Id { get; set; }
        public int SubsidiaryClaimId { get; set; }
        public int ProjectObjectId { get; set; }
    }
}
