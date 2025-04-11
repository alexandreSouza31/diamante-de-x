namespace diamanteDeX.ConsoleApp
{
    internal class Program
    {
        static int idade = 0;
        static void Main(string[] args)
        {           
            while (true)
            {
                Diamante.caracterDoDesenho = 'X';
                ExibirCabecalho();

                int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                if (ExibirMensagemErro(numeroUsuario)==false)
                {
                    DigitarEnterEContinuar();
                    continue;
                }

                DigitarEnterEContinuar();
                
                Diamante.numeroUsuario = numeroUsuario;
                Diamante.DesenharDiamanteCompleto();

                Console.WriteLine();

                bool novoDesenho = DesenharNovamente();
                if (novoDesenho == false) break;
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine($"---------------- Diamante com {Diamante.caracterDoDesenho} ----------------");
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("\nDigite um número inteiro para desenhar o diamante: ");
        }

        static bool ExibirMensagemErro(int numeroUsuario)
        {

            if (numeroUsuario < 3 || numeroUsuario % 2 == 0)
            {
                Console.WriteLine("\nNúmero inválido! Digite um ímpar maior que 1");
                return false;
            }
            return true;
        }

        static bool DesenharNovamente()
        {
            while (true)
            {
                Console.Write("\nDeseja desenhar novamente? [S/N]: ");
                string jogarNovamente = Console.ReadLine().ToUpper();

                if (jogarNovamente == "S")
                {
                    Console.Clear();
                    return true;
                }
                else if (jogarNovamente == "N")
                {
                    return false;
                }
            }
        }

        static void DigitarEnterEContinuar()
        {
            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
