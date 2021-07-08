using System;
using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class GraduateStudentDto : IDto
    {
        public int GraduateStudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GroupName { get; set; }
        public DateTime GraduateDate { get; set; }
    }
}
