internal static class Diamante
{
    public static char caracterDoDesenho = 'X';
    public static int numeroUsuario = 0;

    static void BaseDesenhoDiamante(int qtdEspacos, int qtdDeX, int aumentaOuDiminuiX, int aumentaOuDiminuiEspaco, int qtdlinhas)
    {
        for (int i = 0; i < qtdlinhas; i++)
        {
            for (int espacos = 0; espacos < qtdEspacos; espacos++)
            {
                Console.Write(" ");
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
    static void DesenharBaixoDiamante()
    {        
        int qtdDeX = numeroUsuario - 2;

        BaseDesenhoDiamante(1, numeroUsuario - 2, -2, +1, (numeroUsuario - 1) / 2);
    }

    static void DesenharCimaDiamante()
    {
        int qtdEspacos = (numeroUsuario - 1) / 2;
        int qtdlinhas = qtdEspacos;
        int qtdDeX = 1;

        BaseDesenhoDiamante(qtdEspacos, qtdDeX, +2, -1, qtdlinhas);
    }

    public static void DesenharDiamanteCompleto()
    {
        DesenharCimaDiamante();
        DesenharMeioDiamante();
        DesenharBaixoDiamante();
    }

    static void DesenharMeioDiamante()
    {
        for (int i = 0; i < numeroUsuario; i++)
        {
            Console.Write(caracterDoDesenho);
        }

        Console.WriteLine();
    }
}