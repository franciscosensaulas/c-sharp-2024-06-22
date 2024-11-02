using Microsoft.AspNetCore.Mvc.Rendering;

namespace Web.ViewModels.Forms;

public class ModeloTelaCadastroViewModel
{
    public ModeloCadastrarViewModel Form { get; set; }
    public List<SelectListItem> Marcas { get; set; } = new ();
    public List<SelectListItem> Classificacoes { get; set; } = new();
}