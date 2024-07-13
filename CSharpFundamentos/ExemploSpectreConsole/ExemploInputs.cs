using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSpectreConsole
{
    internal class ExemploInputs
    {
        

        public string SolicitarNome()
        {
            string nome = AnsiConsole.Ask<string>("Digite o nome:");
            return nome;
        }

        public string SolicitarSigno()
        {
            SelectionPrompt<string> selecao = new SelectionPrompt<string>();
            selecao.Title = "Escolha o seu Signo";
            selecao.PageSize = 12;
            string[] signos = new string[]
            {
                "Áries",
                "Touro",
                "Gêmeos",
                "Câncer",
                "Leão",
                "Virgem",
                "Libra",
                "Escorpião",
                "Sagitário",
                "Capricórnio",
                "Aquário",
                "Peixes",
            };
            selecao.SearchEnabled = true;
            selecao.AddChoices(signos);
            string signo = AnsiConsole.Prompt(selecao);
            AnsiConsole.WriteLine($"Escolha o seu Signo: {signo}");
            return signo;
        }

        public int SolicitarIdade()
        {
            int idade = AnsiConsole.Ask<int>("Digite a sua idade");
            return idade;
        }

        public bool DesejaFinalizar()
        {
            bool desejaFinalizar = AnsiConsole.Confirm("Deseja finalizar?");
            return desejaFinalizar;
        }
        public void Executar()
        {
            string nome = SolicitarNome();
            string singo = SolicitarSigno();
            int idade = SolicitarIdade();
            bool desejaFinalizar = DesejaFinalizar();
        }
    }
}
