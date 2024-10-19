namespace Web.Entidades
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string? Descricao { get; set; }
        public bool RegistroAtivo { get; set; } = true;
    }
}
