using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurriculoDigital.Domain.Dtos
{
    public class CoursesDto
    {
        public string curso { get; set; }
        public string instituicao { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }

    }
}