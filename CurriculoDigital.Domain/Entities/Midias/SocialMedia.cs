using CurriculoDigital.Domain.Entities.Base;
using CurriculoDigital.Domain.Entities.Personal;

namespace CurriculoDigital.Domain.Entities.Midias
{
    public class SocialMedia : EntidadeBase
    {
        public string Name { get; set; }
        public string LinkPerfil { get; set; } //-> aqui eu preciso arrumar uma forma de conseguir colocar o link do perfil, mas quando for mostrar para o usuário colocar o nome sei lá algo mais bonito visulmente do que o link não sei se a interface cuida disso 
        public string Icon { get; set; }
        public long PersonalInformationId { get; set; }
        public PersonalInformation PersonalInformation { get; set; }
    }
}