using Entities.Concrete;
using FluentValidation;

namespace Business.CrossCuttingConcerns.Validation
{
    public class StudentExercisesValidator : AbstractValidator<StudentExercises>
    {
        public StudentExercisesValidator()
        {
            RuleFor(s => s.StudentId).NotEmpty();
            RuleFor(s => s.StudentId).GreaterThanOrEqualTo(1);
            RuleFor(s => s.ExerciseId).NotEmpty();
            RuleFor(s => s.ExerciseId).GreaterThan(0);
            RuleFor(s => s.Active).NotEmpty();
        }
    }
}
