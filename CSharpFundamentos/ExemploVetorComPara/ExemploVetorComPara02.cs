using BetterConsoleTables;
using Spectre.Console;
using System.Text;

namespace ExemploVetorComPara
{
    internal class ExemploVetorComPara02
    {
        // Chave => valor
        Dictionary<string, double> precosPorCategoria = new Dictionary<string, double>
        {
            {"ação", 10},
            {"comédia", 7.5},
            {"drama", 8.5},
            {"romance", 4.00},
            {"ficção científica", 12.00},
            {"terror", 11.50},
            {"fantasia", 13.00},
            {"animação", 14.00},
            {"documentário", 5.00},
            {"suspense", 13.75},
        };

        string[] filmes = new string[100];
        string[] categorias = new string[100];
        bool[] filmesDisponibilidade = new bool[100];
        double[] diariaFilmes = new double[100];

        string[] clientes = new string[100];

        int indiceCadastroFilme = 0;
        int indiceCadastroCliente = 0;

        public void PopularBase()
        {
            filmes[0] = "Star Wars a vingança dos sith";
            categorias[0] = "Ficção Científica";
            filmesDisponibilidade[0] = true;
            diariaFilmes[0] = precosPorCategoria[categorias[0].ToLower()];

            filmes[1] = "Transformers";
            categorias[1] = "Ação";
            filmesDisponibilidade[1] = false;
            diariaFilmes[1] = precosPorCategoria[categorias[1].ToLower()];

            filmes[2] = "Titanic";
            categorias[2] = "Romance";
            filmesDisponibilidade[2] = true;
            diariaFilmes[2] = precosPorCategoria[categorias[2].ToLower()];

            indiceCadastroFilme = 3;

            clientes[0] = "Camila Sophia Renata Melo";
            clientes[1] = "Benedito Eduardo Bernardes";
            clientes[2] = "Allana Olivia da Cruz";

            indiceCadastroCliente = 3;
        }

        public void Executar()
        {
            Console.OutputEncoding = Encoding.UTF8;
            PopularBase();
            ApresentarMenu();
        }

        public int ApresentarMenu()
        {
            int indice = 0;
            // indice = indice + 1;
            // indice += 1;
            // int indice = 0;
            // Console.Write(indice++); => 0

            // int indice = 0;
            // Console.Write(++indice); => 1

            int menuEscolhido = -1;
            while (menuEscolhido != 0)
            {
                indice = 0;
                Console.WriteLine($"""
                |‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾|
                |                    Sistema de Locadora                     |  
                |____________________________________________________________|
                | {++indice}  -  Cadastrar Filme                                      |
                | {++indice}  -  Editar Filme                                         |
                | {++indice}  -  Listar Filmes                                        |
                | {++indice}  -  Listar Filmes Disponíveis                            |
                | {++indice}  -  Listar Filmes Alugados                               |
                | {++indice}  -  Cadastrar Cliente                                    |
                | {++indice}  -  Listar Cliente                                       |
                | {++indice}  -  Registrar Locação                                    |
                | {++indice}  -  Registrar Devolução                                  |  
                | 0  -  Encerrar                                             |  
                |____________________________________________________________|
                """);
                Console.Write("Digite o menu desejado: ");
                menuEscolhido = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (menuEscolhido)
                {
                    case 1: CadastrarFilme(); break;
                    case 2: EditarFilme(); break;
                    case 3: ListarFilmes(); break;
                    case 4: ListarFilmesDisponiveis(); break;
                    case 5: ListarFilmesAlugados(); break;
                    case 6: CadastrarCliente(); break;
                    case 7: ListarCliente(); break;
                    case 8: RegistrarLocacao(); break;
                }
                Console.Write("Aperte enter para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
            return menuEscolhido;
        }

        public void CadastrarFilme()
        {
            Console.Write("Digite o nome do filme: ");
            filmes[indiceCadastroFilme] = Console.ReadLine().Trim();

            categorias[indiceCadastroFilme] = SolicitarCategoria();

            // Fazer com o que filme fique disponível para alugar
            filmesDisponibilidade[indiceCadastroFilme] = true;

            string categoria = categorias[indiceCadastroFilme].ToLower();
            double valorDiaria = precosPorCategoria[categoria];
            diariaFilmes[indiceCadastroFilme] = valorDiaria;

            indiceCadastroFilme++;
        }

        public string SolicitarCategoria()
        {
            // Obter todas as chaves (categorias) do dicionário
            string[] categorias = precosPorCategoria.Keys.ToArray();

            string textoSolicitar = "Digite o nome da categoria";
            string categoria = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(textoSolicitar)
                    .PageSize(categorias.Length)
                    .AddChoices(categorias)
                );
            AnsiConsole.WriteLine(textoSolicitar + ": " + categoria);
            return categoria;
        }

        public void EditarFilme()
        {
            Console.WriteLine("Entrou editar filme");
        }

        public void ListarFilmes()
        {
            Console.WriteLine("Lista de Filmes");
            BetterConsoleTables.Table tabela = new BetterConsoleTables.Table("Nome", "Categoria", "Valor Diária", "Disponibilidade");
            tabela.Config = TableConfiguration.Unicode();
            for (int i = 0; i < indiceCadastroFilme; i++)
            {
                string nomeFilme = filmes[i];
                string categoriaFilme = categorias[i];
                double diariaFilme = diariaFilmes[i];
                bool filmeDisponibilidade = filmesDisponibilidade[i];

                string textoDisponibilidade = "Não";
                if (filmeDisponibilidade == true)
                    textoDisponibilidade = "Sim";

                tabela.AddRow(nomeFilme, categoriaFilme, $"R$ {diariaFilme:F2}", textoDisponibilidade);
            }
            Console.Write(tabela.ToString());
        }

        public void ListarFilmesDisponiveis()
        {
            Console.WriteLine("Lista de Filmes Disponíveis");
            BetterConsoleTables.Table tabela = new BetterConsoleTables.Table("Nome", "Categoria", "Valor Diária");
            tabela.Config = TableConfiguration.Unicode();

            for (int i = 0; i < indiceCadastroFilme; i++)
            {
                bool filmeDisponibilidade = filmesDisponibilidade[i];
                if (filmeDisponibilidade == false)
                    continue;

                string nomeFilme = filmes[i];
                string categoriaFilme = categorias[i];
                double diariaFilme = diariaFilmes[i];

                tabela.AddRow(nomeFilme, categoriaFilme, $"R$ {diariaFilme:F2}");
            }
            Console.Write(tabela.ToString());
        }

        public void ListarFilmesAlugados()
        {
            Console.WriteLine("Lista de Filmes Alugados");
            BetterConsoleTables.Table tabela = new BetterConsoleTables.Table("Nome", "Categoria", "Valor Diária");
            tabela.Config = TableConfiguration.Unicode();

            for (int i = 0; i < indiceCadastroFilme; i++)
            {
                bool filmeDisponibilidade = filmesDisponibilidade[i];
                if (filmeDisponibilidade == true)
                    continue;

                string nomeFilme = filmes[i];
                string categoriaFilme = categorias[i];
                double diariaFilme = diariaFilmes[i];

                tabela.AddRow(nomeFilme, categoriaFilme, $"R$ {diariaFilme:F2}");
            }
            Console.Write(tabela.ToString());
        }

        public void CadastrarCliente()
        {
            Console.Write("Digite o nome: ");
            clientes[indiceCadastroCliente] = Console.ReadLine().Trim();

            Console.WriteLine("Cliente cadastrado com sucesso");
            indiceCadastroCliente++;
        }

        public void ListarCliente()
        {
            Console.WriteLine("Lista de Clientes");

            BetterConsoleTables.Table tabela = new BetterConsoleTables.Table("Nome");
            tabela.Config = TableConfiguration.Unicode();
            for (int i = 0; i < indiceCadastroCliente; i++)
            {
                string nome = clientes[i];
                tabela.AddRow(nome);
            }

            Console.WriteLine(tabela.ToString());
        }

        public void RegistrarLocacao()
        {
            string clienteEscolhido = SolicitarCliente();

            string filmeEscolhido = SolicitarFilme();
            int indiceFilmeEscolhido = DescobrirIndiceFilme(filmeEscolhido);
            string categoria = categorias[indiceFilmeEscolhido];
            double preco = precosPorCategoria[categoria.ToLower()];

            int quantidadeDias = SolicitarDiasLocacao();

            filmesDisponibilidade[indiceFilmeEscolhido] = false;

            double precoLocacao = preco * quantidadeDias;
            Console.WriteLine("Preço locação: " + precoLocacao);
        }

        public int DescobrirIndiceFilme(string filmeBuscado)
        {
            for (int i = 0; i < indiceCadastroFilme; i++)
            {
                string filme = filmes[i];
                if (filme == filmeBuscado)
                {
                    return i;
                }
            }
            return -1;
        }

        public string SolicitarCliente()
        {
            string[] clientesCadastrados = new string[indiceCadastroCliente];
            for (int i = 0; i < indiceCadastroCliente; i++)
            {
                string clienteCadastrado = clientes[i];
                clientesCadastrados[i] = clienteCadastrado;
            }

            string titulo = "Escolha o cliente";
            string cliente = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(titulo)
                    .AddChoices(clientesCadastrados));
            return cliente;
        }

        public string SolicitarFilme()
        {
            string[] filmesCadastrados = new string[indiceCadastroFilme];
            for (int i = 0; i < indiceCadastroFilme; i++)
            {
                string filmeCadastrado = filmes[i];
                filmesCadastrados[i] = filmeCadastrado;
            }

            string titulo = "Escolha o filme";
            string filme = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title(titulo)
                    .AddChoices(filmesCadastrados));
            return filme;
        }

        public int SolicitarDiasLocacao()
        {
            int quantidadeDiasLocacao = AnsiConsole.Prompt(
                new TextPrompt<int>("Deseja alugar quantos dias?")
                    .PromptStyle("green")
                    .ValidationErrorMessage("[red]Quantidade de dias inválida[/]")
                    .Validate(quantidade =>
                    {
                        return quantidade switch
                        {
                            <= 0 => ValidationResult.Error("[red]Quantidade deve ser maior que 0[/]"),
                            >= 6 => ValidationResult.Error("[red]Quantidade deve ser menor que 6[/]"),
                            _ => ValidationResult.Success(),
                        };
                    }));

            return quantidadeDiasLocacao;
        }
    }
}
