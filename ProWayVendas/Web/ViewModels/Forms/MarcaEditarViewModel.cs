using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels.Forms
{
    public class MarcaEditarViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é requerido")]
        [MinLength(2, ErrorMessage = "Nome deve conter no mínimo 2 caracteres")]
        [MaxLength(50, ErrorMessage = "Nome deve conter no máximo 50 caracteres")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "CNPJ é requerido")]
        [MinLength(18, ErrorMessage = "CNPJ deve conter no mínimo 18 caracteres")]
        [MaxLength(18, ErrorMessage = "CNPJ deve conter no máximo 18 caracteres")]
        [RegularExpression("[0-9]{2}\\.[0-9]{3}\\.[0-9]{3}\\/[0-9]{4}\\-[0-9]{2}",
            ErrorMessage = "CNPJ deve respeitar o formato '00.000.000/0000-00'")]
        public string? Cnpj { get; set; }
        public string? Descricao { get; set; }
    }
}
