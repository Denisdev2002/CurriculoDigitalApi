using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoDigital.Domain.Dtos
{
    public class ProjectDto
    {
        public string nameProjet { get; set; }
        public List<string> technology { get; set; }
        public string descriptionProject { get; set; }
        public string linkProject { get; set; }
        public string owner { get; set; }
    }
}