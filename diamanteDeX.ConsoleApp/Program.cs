namespace diamanteDeX.ConsoleApp
{
    internal class Program
    {
        //Desenvolver um programa em que, dado um número ímpar como entrada, exibirá um diamante desenhado com a letra 'X'.

        //● O programa deve solicitar ao usuário um número inteiro.[X]
        //● O número deve ser ímpar.Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.[X]
        //● O número de linhas e colunas deve ser igual ao número ímpar fornecido.[X]
        //● A linha central do diamante deve conter o número máximo de Xs.[X]
        //não utilizar número 1 [X]
        //não utilizar números quebrados[]
        static void Main(string[] args)
        {           
            while (true)
            {
                char caracterDoDesenho = 'X';
                ExibirCabecalho(caracterDoDesenho);

                int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                if (ExibirMensagemErro(numeroUsuario)==false)
                {
                    Console.WriteLine("\nPressione Enter tentar novamente:");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.WriteLine();

                DesenharDiamanteCompleto(caracterDoDesenho, numeroUsuario);

                Console.WriteLine();

                bool novoDesenho = DesenharNovamente();
                if (novoDesenho == false) break;
            }
        }

        static void ExibirCabecalho(char caracterDoDesenho)
        {
            Console.Clear();
            Console.WriteLine($"---------------- Diamante com {caracterDoDesenho} ----------------");
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

        static void DesenharDiamanteCompleto(char caracterDoDesenho, int numeroUsuario)
        {
            DesenharCimaDiamante(caracterDoDesenho, numeroUsuario);
            DesenharMeioDiamante(caracterDoDesenho, numeroUsuario);
            DesenharBaixoDiamante(caracterDoDesenho, numeroUsuario);
        }

        static void DesenharCimaDiamante(char caracterDoDesenho,int numeroUsuario)
        {
            int qtdEspacos = (numeroUsuario - 1) / 2;
            int qtdlinhas = qtdEspacos;
            int qtdDeX = 1;

            string escreveEspaco = " ";
            BaseDesenhoDiamante(numeroUsuario, qtdEspacos, qtdDeX, +2, -1, caracterDoDesenho, escreveEspaco, qtdlinhas);
        }

        static void DesenharMeioDiamante(char caracterDoDesenho, int numeroUsuario)
        {      
            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.Write(caracterDoDesenho);
            }
            Console.WriteLine();
        }
        static void DesenharBaixoDiamante(char caracterDoDesenho, int numeroUsuario)
        {
            int qtdEspacos = 1;
            int qtdDeX = numeroUsuario - 2;

            string escreveEspaco = " ";
            BaseDesenhoDiamante(numeroUsuario, 1, numeroUsuario - 2, -2, +1, caracterDoDesenho, escreveEspaco, (numeroUsuario - 1) / 2);
        }

        static void BaseDesenhoDiamante(int numeroUsuario, int qtdEspacos, int qtdDeX, int aumentaOuDiminuiX, int aumentaOuDiminuiEspaco, char caracterDoDesenho, string escreveEspaco , int qtdlinhas)
        {
            for (int i = 0; i < qtdlinhas; i++)
            {
                for (int espacos = 0; espacos < qtdEspacos; espacos++)
                {
                    Console.Write(escreveEspaco);
                }

                for (int x = 0; x < qtdDeX; x++)
                {
                    Console.Write(caracterDoDesenho);
                }

                qtdDeX += aumentaOuDiminuiX;
                qtdEspacos += aumentaOuDiminuiEspaco;

                Console.WriteLine();
            }
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
    }
}
