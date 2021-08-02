using Core.Utilities.Extensions;
using Entities.Dtos;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class UserRegisterValidator : AbstractValidator<UserRegisterDto>
    {
        public UserRegisterValidator()
        {
            RuleFor(u => u.UserName.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.UserName).MinimumLength(3);
            RuleFor(u => u.UserName.Trim()).NotEqual("");
            RuleFor(u => u.UserName.ToLower().Contains("username")).NotEqual(true);

            RuleFor(u => u.Password.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.Password).MinimumLength(5);
            RuleFor(u => u.PasswordRepeat.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.Password + " " + u.PasswordRepeat).Must(EqualPass);
            RuleFor(u => u.Password).Must(MustContains);

            RuleFor(u => u.FirstName.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.FirstName).Must(NotStartWith);

            RuleFor(u => u.LastName.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.LastName).MinimumLength(3);
            RuleFor(u => u.LastName).Must(NotStartWith);

            RuleFor(u => u.Email.IsNullOrEmpty()).NotEqual(true);
            RuleFor(u => u.Email).EmailAddress();
        }
        private bool NotStartWith(string name)
        {
            return !(name.StartsWith("ğ") | name.StartsWith("Ğ") | name.StartsWith("ı") | name.StartsWith("I"));
        }

        private bool EqualPass(string duplicatePass)
        {
            var passwords = duplicatePass.Split();

            return passwords[0] == passwords[1];
        }

        private bool MustContains(string parameter)
        {
            bool haveUpper = false,
                 haveDigit = false,
                 haveLower = false;

            foreach (var p in parameter)
            {
                if (char.IsUpper(p)) haveUpper = true;
                else if (char.IsLower(p)) haveLower = true;
                else if (char.IsDigit(p)) haveDigit = true;
            }

            if (haveUpper & haveLower & haveDigit) return true;
            return false;
        }
    }
}
