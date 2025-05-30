using blue_agenda_api.Domain.Enums;

namespace blue_agenda_api.Application.ViewModels
{
    public class DadosContatoViewModel : BaseViewModel
    {
        
        public string Email { get; set; }
        public string Telefone { get; set; }
        public EnumTipoTelefone TipoTelefone { get; set; }
    }
}
