namespace blue_agenda_api.Domain.Enums
{
    /// <summary>
    /// Define os tipos possíveis de telefone para um contato.
    /// </summary>
    /// <remarks>
    /// Este enum é utilizado para categorizar os números de telefone associados a uma pessoa de contato,
    /// facilitando a identificação da finalidade de cada número (ex: uso pessoal, profissional).
    /// </remarks>
    public enum EnumTipoTelefone
    {
        /// <summary>
        /// Representa um telefone residencial.
        /// </summary>
        Residencial = 1,

        /// <summary>
        /// Representa um telefone celular.
        /// </summary>
        Celular = 2,

        /// <summary>
        /// Representa um telefone comercial.
        /// </summary>
        Comercial = 3
    }
}
