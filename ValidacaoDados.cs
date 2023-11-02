namespace Jogo_de_Adivinhação
{
    public class ValidacaoDados
    {
        public double LerValidarDouble(string message, out double numero)
        {
            while (true)
            {
                Console.Write(message);
                string? input = Console.ReadLine();

                if (double.TryParse(input, out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Forneça um número válido.");
                }
            }
        }
        public string LerValidarString(string message)
        {

            string? input;

            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Forneça uma string válida.");
                }
            }
        }
    }
}