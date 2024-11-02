namespace Repositorios.Entidades
{
    public class EntidadeBase
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public bool RegistroAtivo { get; set; }
    }
}
