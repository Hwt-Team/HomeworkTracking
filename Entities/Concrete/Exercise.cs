using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Exercise : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Deadline { get; set; }
    }
}
