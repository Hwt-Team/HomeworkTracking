using Core.Entities.Dtos;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class UserLoginValidator : AbstractValidator<UserLoginDto>
    {
        public UserLoginValidator()
        {
            RuleFor(u => u.EmailOrUsername).NotEmpty();
            RuleFor(u => u.EmailOrUsername).NotEqual(" ");
            RuleFor(u => u.Password).NotEqual(" ");
        }
    }
}
