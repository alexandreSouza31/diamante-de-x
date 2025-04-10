namespace diamanteDeX.ConsoleApp
{
    internal class Program
    {
        //Desenvolver um programa em que, dado um número ímpar como entrada, exibirá um diamante desenhado com a letra 'X'.

        //● O programa deve solicitar ao usuário um número inteiro.[X]
        //● O número deve ser ímpar.Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.[X]
        //● O número de linhas e colunas deve ser igual ao número ímpar fornecido.[ ]
        //● A linha central do diamante deve conter o número máximo de Xs.[ ]
        //não utilizar número 1 [X]
        //não utilizar números quebrados[]
        static void Main(string[] args)
        {           
            while (true)
            {
                ExibirCabecalho();

                int numeroUsuario = Convert.ToInt32(Console.ReadLine());

                ExibirMensagemErro(numeroUsuario);

                Console.WriteLine("\nPressione Enter para continuar...");
                
                DesenharCimaDiamante(numeroUsuario);
                DesenharMeioDiamante(numeroUsuario);

                Console.ReadLine();
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------- Diamante com X ----------------");
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("\nDigite um número inteiro para desenhar o diamante: ");
        }

        static void ExibirMensagemErro(int numeroUsuario)
        {

            if (numeroUsuario < 3 || numeroUsuario % 2 == 0)
            {
                Console.WriteLine("Número inválido! Digite um ímpar maior que 1");

            }
        }

        static void DesenharCimaDiamante(int numeroUsuario)
        {
            int qtdEspacos = (numeroUsuario - 1) / 2;
            int qtdlinhas = qtdEspacos;
            int qtdDeX = 1;

            string escreveEspaco = " ";
            string escreveX = "X";

            for(int i = 0; i < qtdlinhas; i++)
            {
                for (int espacos=0;espacos<qtdEspacos;espacos++)
                {
                    Console.Write(escreveEspaco);
                }

                for (int x=0;x<qtdDeX;x++)
                {
                    Console.Write(escreveX);
                }

                qtdDeX += 2;
                qtdEspacos--;

                Console.WriteLine();
            }
        }

        static void DesenharMeioDiamante(int numeroUsuario)
        {
            string escreveX = "X";
      
            for (int i = 0; i < numeroUsuario; i++)
            {
                Console.Write(escreveX);
            }
            Console.WriteLine();
        }
    }
}
