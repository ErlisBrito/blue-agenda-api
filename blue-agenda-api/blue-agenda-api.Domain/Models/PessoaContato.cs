namespace blue_agenda_api.Domain.Models
{
    public class PessoaContato : EntityBase
    {
        public string Nome { get; set; }
        public List<DadosContato> DadosContato { get; set; }

    }
}
