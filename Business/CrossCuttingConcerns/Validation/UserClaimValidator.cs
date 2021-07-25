using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class UserClaimValidator : AbstractValidator<UserClaim>
    {
        public UserClaimValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.UserId).GreaterThan(0);
            RuleFor(u => u.ClaimId).NotEmpty();
            RuleFor(u => u.ClaimId).GreaterThan(0);
        }
    }
}
