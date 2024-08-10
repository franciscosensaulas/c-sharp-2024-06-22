using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploBancoDadoAdoNet
{
    internal class CategoriaPrincipal
    {
        CategoriaRepositorio repositorio = new CategoriaRepositorio();

        public void Executar() {
            var opcaoDesejada = 9999;
            while (opcaoDesejada != 0) {
                Console.Write("""
                1 - Listar
                2 - Cadastrar
                3 - Alterar
                4 - Apagar
                0 - Sair
                Digite a opção desejada: 
                """);
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcaoDesejada) {
                    case 1: Listar(); break;
                    case 2: Cadastrar(); break;
                    case 3: Alterar(); break;
                    case 4: Apagar(); break;
                }
            }
        }

        private void Cadastrar(){
            Console.Write("Digite o nome: ");
            var nome = Console.ReadLine().Trim();

            Console.Write("Digite o descricao: ");
            var descricao = Console.ReadLine().Trim();
            repositorio.Adicionar(nome, descricao);
        }
        private void Listar(){
            repositorio.ObterTodos();
        }

        private void Apagar(){
            // Listar todas as categorias
            repositorio.ObterTodos();
            // Perguntar qual deseja apagar
            Console.Write("Digite o id da categoria que deseja apagar: ");
            int idParaApagar = Convert.ToInt32(Console.ReadLine());
            // Realizar a ação de apagar essa categoria na
            // tabela de categorias do nosso BD.
            repositorio.Apagar(idParaApagar);
        }

        private void Alterar() {
            // Listar todas as categorias
            repositorio.ObterTodos();
            // Perguntar qual deseja alterar
            Console.Write("Digite o id da categoria que deseja alterar: ");
            int idParaEditar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o novo nome: ");
            string nome = Console.ReadLine().Trim();
            Console.WriteLine("Digite a nova descricao: ");
            string descricao = Console.ReadLine().Trim();
            repositorio.Alterar(idParaEditar, nome, descricao);
        }
    }
}
