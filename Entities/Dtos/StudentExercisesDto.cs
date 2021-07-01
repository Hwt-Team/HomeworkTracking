using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class StudentExercisesDto : IDto
    {
        public int StudentExercisesId { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
    }
}
