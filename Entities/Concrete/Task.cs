using System;
using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Task : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public DateTime? Deadline { get; set; }
        public int StateId { get; set; }
    }
}
