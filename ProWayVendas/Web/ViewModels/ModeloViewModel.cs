﻿using Repositorios.Enums;

namespace Web.ViewModels
{
    public class ModeloViewModel
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public ModeloClassificacao Classificacao { get; set; }
    }
}
