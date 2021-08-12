using Core.Entities.Concrete;
using FluentValidation;
namespace Business.CrossCuttingConcerns.Validation
{
    public class MainClaimValidator : AbstractValidator<MainClaim>
    {
        public MainClaimValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(2);
        }
    }
}
