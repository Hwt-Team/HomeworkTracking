using Core.Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class ProjectObjectClaimValidator :AbstractValidator<ProjectObjectClaim>
    {
        public ProjectObjectClaimValidator()
        {
            RuleFor(c => c.ProjectObjectId).NotNull();
            RuleFor(c => c.ProjectObjectId).GreaterThan(0);
            RuleFor(c => c.SubsidiaryClaimId).NotNull();
            RuleFor(c => c.SubsidiaryClaimId).GreaterThan(0);

        }
    }
}
