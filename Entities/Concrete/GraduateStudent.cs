using System;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class GraduateStudent :  Student, IEntity
    {
        public DateTime GraduateDate { get; set; }
    }

    //public class GraduateStudent : IEntity
    //{
    //    public int Id { get; set; }
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public int GroupId { get; set; }
    //    public DateTime GraduateDate { get; set; }
    //}
}
