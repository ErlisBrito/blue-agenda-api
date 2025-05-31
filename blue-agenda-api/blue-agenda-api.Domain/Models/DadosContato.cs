using blue_agenda_api.Domain.Enums;

namespace blue_agenda_api.Domain.Models
{
    public class DadosContato : EntityBase
    {
        public string Email { get; set; }   
        public string Telefone { get; set; }        
        public EnumTipoTelefone TipoTelefone { get; set; }

    }
}
