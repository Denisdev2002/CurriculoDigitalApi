using System.ComponentModel.DataAnnotations;

namespace CurriculoDigital.Domain.Entities.Base
{
    public class EntidadeBase
    {
        [Key]
        public virtual long Id { get; set; }
        public virtual DateTime DataCriacao { get; set; }
        public virtual DateTime DataAlteracao { get; set; }

        public EntidadeBase()
        {
            DataCriacao = DateTime.UtcNow;
            DataAlteracao = DateTime.UtcNow;
        }
    }
}