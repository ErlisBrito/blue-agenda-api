namespace blue_agenda_api.Application.ViewModels
{
    public class PessoaContatoViewModel : BaseViewModel
    {
        public string Nome { get; set; }
        public List<DadosContatoViewModel> DadosContato { get; set; }
    }
}
