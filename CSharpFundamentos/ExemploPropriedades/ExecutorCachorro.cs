namespace ExemploPropriedades
{
    internal class ExecutorCachorro
    {
        public void Executar()
        {
            // Instanciando um objeto chamado bob da classe Cachorro
            Cachorro bob = new Cachorro();
            // Atriuíndo valor para as propriedades
            bob.Nome = "Bob";
            bob.Nome.Trim();
            bob.Raca = "Bordercoile";
            bob.Altura = 1.40;
            bob.Adotado = true;
            bob.DataNascimento = new DateTime(2020, 02, 3, 09, 50, 32); // 03/fev/2020 às 09:50:32

            // Intanciando outro objeto chamado trex da classe Cachorro
            Cachorro trex = new Cachorro();
            // Atribuíndo valor para as propridades
            trex.Nome = "Rex";
            trex.Altura = 0.30;
            trex.Raca = "Pinscher";

            Console.WriteLine($"""
                Dados cachorro 1:
                    Nome: {bob.Nome}
                    Raça: {bob.Raca}
                    Altura: {bob.Altura}
                    Adotado: {bob.Adotado}
                    Data de Nascimento: {bob.DataNascimento}

                Dados cachorro 2:
                    Nome: {trex.Nome}
                    Raça: {trex.Raca}
                    Altura: {trex.Altura}
                    Adotado: {trex.Adotado}
                    Data de Nascimento: {trex.DataNascimento}
                """);
        }
    }
}
