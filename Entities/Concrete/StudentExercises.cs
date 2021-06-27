using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class StudentExercises : IEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExerciseId { get; set; }
        public bool Active { get; set; }
    }
}
