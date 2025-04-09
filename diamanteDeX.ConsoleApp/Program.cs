namespace diamanteDeX.ConsoleApp
{
    internal class Program
    {
        //Desenvolver um programa em que, dado um número ímpar como entrada, exibirá um diamante desenhado com a letra 'X'.

        //● O programa deve solicitar ao usuário um número inteiro.[X]
        //● O número deve ser ímpar.Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.[X]
        //● O número de linhas e colunas deve ser igual ao número ímpar fornecido.[ ]
        //● A linha central do diamante deve conter o número máximo de Xs.[ ]
        //não utilizar número 1 [ ]
        //não utilizar números quebrados[]
        static void Main(string[] args)
        {
            while (true) 
            {
                ExibirCabecalho();

                int numeroUsuario=Convert.ToInt32(Console.ReadLine());

                ExibirMensagemErro(numeroUsuario);

                Console.WriteLine("\nPressione Enter para continuar...");
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
    }
}
