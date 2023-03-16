using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioKleberson
{
    internal class JogoBiblioteca
    {
        //Atributos:
        public string NomeJogo { get; set; }
        public string Produtora { get; set; }
        public string Lancamento { get; set; }
        public int Quantidade { get; set; }
        public string PosicaoEstante { get; set; }

        //Variáveis:
        int opcao = 0;
        int quantidadeJogos, escolhaBusca;
        string nomeDoJogo, nomeDaProdutora;

        //Listas:
        List<JogoBiblioteca> jogoList = new List<JogoBiblioteca>();

        //Métodos:
        public void Opcoes()
        {
            Console.ForegroundColor = ConsoleColor.White;
            opcao = 0;
            Console.WriteLine("Digite 1 para adicionar um jogo");
            Console.WriteLine("Digite 2 para procurar um jogo");
            Console.WriteLine("Digite 3 para listar todos os jogos");
            Console.WriteLine("Digite 4 para fechar o programa");
        }
        public void AdicionarJogo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Quantos jogos deseja adicionar?");
            quantidadeJogos = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < quantidadeJogos; i++)
            {
                JogoBiblioteca jogo = new JogoBiblioteca();
                Console.WriteLine($"Digite o Nome do {i + 1}° jogo: ");
                jogo.NomeJogo = Console.ReadLine();
                Console.WriteLine($"Digite a produtora do {i + 1}° jogo: ");
                jogo.Produtora = Console.ReadLine();
                Console.WriteLine($"Digite o ano de lançamento do {i + 1}° jogo: ");
                jogo.Lancamento = Console.ReadLine();
                Console.WriteLine($"Digite a quantidade em estoque do {i + 1}° jogo: ");
                jogo.Quantidade = int.Parse(Console.ReadLine());
                Console.WriteLine($"Digite a posição em que está o {i + 1}° jogo: ");
                jogo.PosicaoEstante = Console.ReadLine();
                Console.Clear();
                jogoList.Add(jogo);
            }
        }
        public void BuscarJogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Buscar jogo por: [1]Nome do Jogo, [2] Nome da Produtora, [3]Nome do Jogo e Produtora");
            escolhaBusca = int.Parse(Console.ReadLine());
            Console.Clear();

            if (escolhaBusca == 1)
            {
                Console.WriteLine("Digite o Nome do jogo que deseja buscar: ");
                nomeDoJogo = Console.ReadLine();
                List<JogoBiblioteca> jogosBuscados = jogoList.Where(x => x.NomeJogo == nomeDoJogo).ToList();

                if (jogosBuscados.Count > 0)
                {
                    for (int i = 0; i < jogosBuscados.Count; i++)
                    {
                        Console.WriteLine("================================================================");
                        Console.WriteLine($"O nome do jogo é: " + jogosBuscados[i].NomeJogo);
                        Console.WriteLine($"A produtora do jogo é: " + jogosBuscados[i].Produtora);
                        Console.WriteLine($"O ano de lançamento desse jogo é: " + jogosBuscados[i].Lancamento);
                        Console.WriteLine($"A quantidade desse jogo em estoque é: " + jogosBuscados[i].Quantidade);
                        Console.WriteLine($"A posição em que se encontram os jogos é: " + jogosBuscados[i].PosicaoEstante);
                        Console.WriteLine("================================================================");
                    }
                }
                else
                {
                    if (jogoList.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Você digitou o nome incorreto.");
                    }
                    else
                    {
                        Console.WriteLine("Não existe livros na biblioteca.");
                    }

                }
            }
            else if (escolhaBusca == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite o nome da produtora que deseja buscar: ");
                nomeDaProdutora = Console.ReadLine();
                List<JogoBiblioteca> jogosBuscados = jogoList.Where(x => x.Produtora == nomeDaProdutora).ToList();

                if (jogosBuscados.Count > 0)
                {
                    for (int i = 0; i < jogosBuscados.Count; i++)
                    {
                        Console.WriteLine("================================================================");
                        Console.WriteLine($"O nome do jogo é: " + jogosBuscados[i].NomeJogo);
                        Console.WriteLine($"A produtora do jogo é: " + jogosBuscados[i].Produtora);
                        Console.WriteLine($"O ano de lançamento desse jogo é: " + jogosBuscados[i].Lancamento);
                        Console.WriteLine($"A quantidade desse jogo em estoque é: " + jogosBuscados[i].Quantidade);
                        Console.WriteLine($"A posição em que se encontram os jogos é: " + jogosBuscados[i].PosicaoEstante);
                        Console.WriteLine("================================================================");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não foi encontrado o nome digitado no estoque.");
                }
            }
            else if (escolhaBusca == 3)
            {
                Console.WriteLine("Digite o Nome do livro que deseja buscar: ");
                nomeDoJogo = Console.ReadLine();
                Console.WriteLine("Digite o Nome do Author que deseja buscar: ");
                nomeDaProdutora = Console.ReadLine();
                List<JogoBiblioteca> jogosBuscados = jogoList.Where(x => x.NomeJogo == nomeDoJogo && x.Produtora == nomeDaProdutora).ToList();

                if (jogosBuscados.Count > 0)
                {
                    for (int i = 0; i < jogosBuscados.Count; i++)
                    {
                        Console.WriteLine("================================================================");
                        Console.WriteLine($"O nome do jogo é: " + jogosBuscados[i].NomeJogo);
                        Console.WriteLine($"A produtora do jogo é: " + jogosBuscados[i].Produtora);
                        Console.WriteLine($"O ano de lançamento desse jogo é: " + jogosBuscados[i].Lancamento);
                        Console.WriteLine($"A quantidade desse jogo em estoque é: " + jogosBuscados[i].Quantidade);
                        Console.WriteLine($"A posição em que se encontram os jogos é: " + jogosBuscados[i].PosicaoEstante);
                        Console.WriteLine("================================================================");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não foi encontrado os nomes digitados na biblioteca.");
                }

            }
        }
        public void ListarJogos()
        {
            if (jogoList.Count > 0)
            {
                for (int i = 0; i < jogoList.Count; i++)
                {
                    Console.WriteLine("================================================================");
                    Console.WriteLine($"O nome do jogo é: " + jogoList[i].NomeJogo);
                    Console.WriteLine($"A produtora do jogo é: " + jogoList[i].Produtora);
                    Console.WriteLine($"O ano de lançamento desse jogo é: " + jogoList[i].Lancamento);
                    Console.WriteLine($"A quantidade desse jogo em estoque é: " + jogoList[i].Quantidade);
                    Console.WriteLine($"A posição em que se encontram os jogos é: " + jogoList[i].PosicaoEstante);
                    Console.WriteLine("================================================================");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe nenhum jogo no nosso estoque.");
                Console.WriteLine("========================================================================");
            }
        }
        
        //Método onde tem a lógica do programa.
        public void Program()
        {
            JogoBiblioteca jogo = new JogoBiblioteca();
            while (opcao != 4)
            {
                jogo.Opcoes();
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    jogo.AdicionarJogo();
                }
                else if (opcao == 2)
                {
                    jogo.BuscarJogo();
                }
                else if (opcao == 3)
                {
                    jogo.ListarJogos();
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("O programa foi finalizado.");
                    opcao = 4;
                }
            }
        }
    }
}
