using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaObjetos
{
    internal class ExecutorCarros
    {
        public void Executar()
        {
            // Create
            // Read
            // Update
            // Delete
            var exemploListaCarros = new ExemploListaCarros();
            exemploListaCarros.Adicionar(); // Create
            exemploListaCarros.ListarTodos(); // Read

            Console.Write("Aperte enter para continuar...");
            while (true)
            {
                var tecla = Console.ReadKey(intercept: true);
                if (tecla.Key == ConsoleKey.Enter)
                    break;
            }

            Console.Clear();
            exemploListaCarros.Apagar(); // Delete
            exemploListaCarros.ListarTodos();

            Console.Write("Aperte enter para continuar...");
            while (true)
            {
                var tecla = Console.ReadKey(intercept: true);
                if (tecla.Key == ConsoleKey.Enter)
                    break;
            }

            Console.Clear();
            exemploListaCarros.Editar(); // Update
            exemploListaCarros.ListarTodos();
        }
    }
}
