using System.ComponentModel.DataAnnotations;

namespace Web.ViewModels.Forms;

public class ModeloCadastrarViewModel
{
    public string? Nome { get; set; }
    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }
    public int? Classificacao { get; set; }
}