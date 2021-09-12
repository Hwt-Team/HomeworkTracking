using Core.Entities.Abstract;

namespace Core.Entities.Concrete
{
    public class ProjectObject : IEntity
    {
        public int Id { get; set; }
        public string NameSpace { get; set; }
        public string ClassName { get; set; }
        public string ObjectName { get; set; }
        public int ObjectTypeId { get; set; }
    }
}
