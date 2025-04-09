namespace diamanteDeX.ConsoleApp
{
    internal class Program
    {
        //Desenvolver um programa em que, dado um número ímpar como entrada, exibirá um diamante desenhado com a letra 'X'.

        //● O programa deve solicitar ao usuário um número inteiro.[ ]
        //● O número deve ser ímpar.Caso contrário, o programa deve informar que a entrada é inválida e solicitar um novo número.[ ]
        //● O número de linhas e colunas deve ser igual ao número ímpar fornecido.[ ]
        //● A linha central do diamante deve conter o número máximo de Xs.[ ]
        //não utilizar número 1 [ ]
        //não utilizar números quebrados[]
        static void Main(string[] args)
        {
            while (true)
            {
                ExibirCabecalho();
            }
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------- Diamante com X ----------------");
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("\nDigite um número inteiro para desenhar o diamante: ");
        }
    }
}
