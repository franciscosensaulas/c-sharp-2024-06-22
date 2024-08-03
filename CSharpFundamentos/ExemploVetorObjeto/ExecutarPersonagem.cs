namespace ExemploVetorObjeto
{
    internal class ExecutarPersonagem
    {
        public void Executar()
        {
            Personagem[] personagens = new Personagem[3];
            var kratos = new Personagem();
            kratos.Nome = "Bom de Guerra";
            kratos.Vida = 2;
            personagens[0] = kratos;

            var annie = new Personagem();
            annie.Nome = "Annie";
            annie.Vida = 250;
            personagens[1] = annie;

            personagens[2] = new Personagem();
            personagens[2].Nome = "Joel";
            personagens[2].Vida = 10;

            for (int i = 0; i < personagens.Length; i++)
            {
                var personagen = personagens[i];
                Console.WriteLine($"""
                Nome: {personagen.Nome}
                Vida: {personagen.Vida}
                """);
            }
        }
    }
}
