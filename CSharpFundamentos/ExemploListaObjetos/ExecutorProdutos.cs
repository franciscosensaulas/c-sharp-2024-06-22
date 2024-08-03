using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaObjetos
{
    internal class ExecutorProdutos
    {
        // new ExecutorProdutos().Executar();
        public void Executar()
        {
            var exemploListaProdutos = new ExemploListaProdutos();

            int menu = -1;
            while(menu != 8000)
            {
                Console.WriteLine("""
                    1 - Cadastrar
                    2 - Editar
                    3 - Apagar
                    4 - Listar todos
                    8000 - Sair
                    """);
                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menu)
                {
                    case 1:
                        exemploListaProdutos.Adicionar();
                        break;
                    case 2:
                        //exemploListaProdutos.Editar();
                        break;
                    case 3:
                        exemploListaProdutos.Apagar();
                        break;
                    case 4:
                        exemploListaProdutos.ListarTodos();
                        break;
                }
            }
        }
    }
}
