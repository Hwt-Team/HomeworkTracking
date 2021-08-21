using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Dtos
{
    public class ProjectObjectClaimDto: IDto
    {
        public int ProjectObjectClaimId { get; set; }
        public string ObjectAdress  { get; set; }
        public string SubsidiaryClaimName { get; set; }
    }
}
