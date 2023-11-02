using Jogo_de_Adivinhação;

namespace Jogo_de_Adivinhacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random random = new();
            ValidacaoDados validacao = new();
            JogoAdivinhacao iniciar_jogo = new();

            bool entradaValida = false;
            while (!entradaValida)
            {

                Console.Clear();
                Console.WriteLine("\nOpções de Dificuldade");
                Console.WriteLine("\n1 - Fácil - 8 Tentativas");
                Console.WriteLine("2 - Medio - 6 Tentativas");
                Console.WriteLine("3 - Dificil - 4 Tentativas");
                Console.WriteLine("4 - Insano - 2 Tentativas");
                string dificuldade = validacao.LerValidarString("\nEscolha o nivel de dificuldade: ");
                int numeroAleatorio = random.Next(0, 999);
                int tentativas;

                switch (dificuldade)
                {
                    case "1":
                        tentativas = 8;
                        iniciar_jogo.ExecutarJogo(numeroAleatorio, tentativas);
                        entradaValida = true;
                        break;
                    case "2":
                        tentativas = 6;
                        iniciar_jogo.ExecutarJogo(numeroAleatorio, tentativas);
                        entradaValida = true;
                        break;
                    case "3":
                        tentativas = 4;
                        iniciar_jogo.ExecutarJogo(numeroAleatorio, tentativas);
                        entradaValida = true;
                        break;
                    case "4":
                        tentativas = 2;
                        iniciar_jogo.ExecutarJogo(numeroAleatorio, tentativas);
                        entradaValida = true;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção entre 1 e 4");
                        Console.WriteLine("Aperta qualquer tecla para voltar.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}