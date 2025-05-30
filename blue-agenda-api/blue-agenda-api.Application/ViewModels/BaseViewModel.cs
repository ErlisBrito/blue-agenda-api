namespace blue_agenda_api.Application.ViewModels
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
