using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class GraduateStudentValidator : AbstractValidator<GraduateStudent>
    {
        public GraduateStudentValidator()
        {
            RuleFor(s => s.FirstName).NotEmpty();
            RuleFor(s => s.FirstName).MinimumLength(3);
            RuleFor(s => s.FirstName).Must(NotStartWith);
            RuleFor(s => s.GraduateDate).NotEmpty();
        }

        private bool NotStartWith(string name)
        {
            return !(name.StartsWith("ğ") | name.StartsWith("Ğ") | name.StartsWith("ı") | name.StartsWith("I"));
        }
    }
}
