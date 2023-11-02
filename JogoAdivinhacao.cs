namespace Jogo_de_Adivinhação
{
    public class JogoAdivinhacao
    {
        ValidacaoDados validacao = new();
        public void ExecutarJogo(int numeroAleatorio, int tentativas)
        {
            double numero;
            double menor = 0;
            double maior = 999;
            int tentativaInicial = 1;

            while (tentativaInicial <= tentativas)
            {
                Console.WriteLine($"\nTentativa {tentativaInicial} de {tentativas}");

                validacao.LerValidarDouble($"Escolha um número de {menor} a {maior}: ", out numero);

                if (numero >= menor && numero <= maior)
                {
                    if (numeroAleatorio > numero)
                    {
                        menor = numero;
                    }
                    else if (numeroAleatorio < numero)
                    {
                        maior = numero;
                    }
                    if (numeroAleatorio == numero)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        Console.WriteLine($"O número aleatório é {numeroAleatorio}");
                        break;
                    }
                    tentativaInicial++;
                }
                else
                {
                    Console.WriteLine("Por favor, escolha um número dentro do intervalo fornecido anteriormente!");
                }
            }
            Console.WriteLine("\nOps. Parece que você não conseguiu acertar! ");
            Console.WriteLine($"O número aleatório era {numeroAleatorio} \n");
        }
    }
}
