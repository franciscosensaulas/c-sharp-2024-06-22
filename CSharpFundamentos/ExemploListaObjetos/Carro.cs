using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploListaObjetos
{
    internal enum Categoria
    {
        Sedan,
        Hatch,
        Suv,
        Sport
    }

    internal class Carro
    {
        // Propriedades
        public int Id;
        public string Nome;
        public double Preco;
        public short AnoFabricacao;
        public short AnoModelo;
        public Categoria Categoria;
        // byte => -128 ..0.. 127
        // short => -32768 ..0.. 32767
        // int => -2bi ..0.. 2bi
        // long mto grande

        public override string ToString()
        {
            return $"""
                Id: {Id}
                Nome: {Nome}
                Preco: {Preco}
                AnoFabricacao: {AnoFabricacao}
                AnoModelo: {AnoModelo}
                Categoria: {Categoria}
                """;
        }

    }
}
