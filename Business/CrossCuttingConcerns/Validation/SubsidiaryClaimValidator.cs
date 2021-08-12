using Core.Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class SubsidiaryClaimValidator : AbstractValidator<SubsidiaryClaim>
    {
        public SubsidiaryClaimValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
