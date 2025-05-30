namespace blue_agenda_api.Domain.Models
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
    }
}
