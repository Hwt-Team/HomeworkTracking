using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.FirstName).Must(NotStartWith)
                .WithMessage("Firstname can not start with 'ı', 'I', 'ğ', 'Ğ'");

            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u=>u.LastName).Must(NotStartWith)
                .WithMessage("Lastname can not start with 'ı', 'I', 'ğ', 'Ğ'");

            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MinimumLength(10);
            RuleFor(u => u.Email).EmailAddress();

            RuleFor(u => u.PasswordHash).NotEmpty();
            RuleFor(u => u.PasswordSalt).NotEmpty();

            RuleFor(u => u.UserName).NotEmpty();
            RuleFor(u => u.UserName).MinimumLength(3);

            RuleFor(u => u.Status).NotEmpty();
        }

        private bool NotStartWith(string name)
        {
            return !(name.StartsWith("ı")
                   | name.StartsWith("I")
                   | name.StartsWith("ğ")
                   | name.StartsWith("Ğ"));
        }
    }
}
