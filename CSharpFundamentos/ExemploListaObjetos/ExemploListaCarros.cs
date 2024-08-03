using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaObjetos
{
    internal class ExemploListaCarros
    {
        public List<Carro> Carros = new List<Carro>();

        public void Adicionar() {
        
            // Instanciando um objeto da classe CArro
            var hb20 = new Carro();
            hb20.Id = 1;
            // Definindo as propriedades do objeto hb20
            hb20.Nome = "HB20 Sedan";
            hb20.AnoFabricacao = 2021;
            hb20.AnoModelo = 2022;
            hb20.Preco = 80_999.90;
            hb20.Categoria = Categoria.Sedan;

            // Adicionar o objeto hb20 na lista de carros
            Carros.Add(hb20);

            //var onix = new Carro();
            //onix.Categoria = Categoria.Hatch;

            var hilux = new Carro();
            hilux.Id = 2;
            hilux.Categoria = Categoria.Suv;
            hilux.AnoFabricacao = 2024;
            hilux.AnoModelo = 2024;
            hilux.Nome = "Hilux";
            hilux.Preco = 200_920.00;

            Carros.Add(hilux);

            var vectra = new Carro();
            vectra.Id = 3;
            vectra.Categoria = Categoria.Sedan;
            vectra.AnoFabricacao = 2002;
            vectra.AnoModelo = 2013;
            vectra.Nome = "Vectra";
            vectra.Preco = 5000.00;

            Carros.Add(vectra);

            //Console.WriteLine(hilux.Categoria);
        }

        public void Apagar()
        {
            string carroParaApagar = "VectrA";

            for (int i = 0; i < Carros.Count; i++)
            {
                var carro = Carros[i];
                if (carro.Nome.ToLower() == carroParaApagar.ToLower())
                {
                    // Remover da lista por objeto
                    Carros.Remove(carro);
                    // Remover da lista por indice
                    // Carros.RemoveAt(i);
                    Console.WriteLine($"{carro.Nome} apagado com sucesso!\n");
                }
            }
        }

        public void ListarTodos() {
            Console.WriteLine("Carros: ");
            for (int i = 0; i < Carros.Count; i++)
            {
                var carro = Carros[i];
                Console.WriteLine(carro.ToString() + "\n");
            }
            Console.WriteLine("\n\n");
        }

        public void Editar() {
            string carroParaEditar = "Hilux";

            for (int i = 0; i < Carros.Count; i++)
            {
                // Pegar o carro da lista de carros
                var carro = Carros[i];

                if(carro.Nome == carroParaEditar)
                {
                    carro.Preco = 2.00;
                    carro.AnoModelo = 2025;
                    Console.WriteLine($"{carro.Nome} alterada com sucesso!\n");
                }
            }
        
        }

    }
}
