int qtdLinhas = 3, qtdColunas = 3, inicio = 0, fim = 0;
int[,] matriz = new int[qtdLinhas, qtdColunas];
int[] somaLinha = new int[6];
int[] somaColuna = new int[6];
int somaDiagonal = 0, somaDiagonal2 = 0;

int[,] CriarMatriz(int[,] matrizParam, int i, int f)
{
    Console.Write("A partir de qual número a matriz deve ser gerada: ");
    inicio = int.Parse(Console.ReadLine());
    Console.Write("Até qual número a matriz deve ser gerada: ");
    fim = int.Parse(Console.ReadLine());
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            matrizParam[linha, coluna] = new Random().Next(inicio, fim);
        }
    }
    inicio = i;
    fim = f;
    return matrizParam;
}

void ImprimirMatriz(int[,] matrizParam, string mensagem)
{
    Console.WriteLine(mensagem);
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            Console.Write(matrizParam[linha, coluna] + " ");
        }
    }
}

int Menu()
{
    Console.WriteLine("ESCOLHA UMA DAS OPÇÕES ABAIXO");
    Console.WriteLine("1- ADIÇÃO DAS LINHAS DA MATRIZ");
    Console.WriteLine("2- ADIÇÃO DAS COLUNAS DA MATRIZ");
    Console.WriteLine("3- ADIÇÃO DA DIAGONAL PRINCIPAL DA MATRIZ");
    Console.WriteLine("4- ADIÇÃO DA DIAGONAL SECUNDARIA DA MATRIZ");
    Console.Write("OPCAO ESCOLHIDA: ");
    int opcao = int.Parse(Console.ReadLine());

    return opcao;
}

void SomarLinhaMatriz(int[,] matrizParam)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            somaLinha[linha] += matrizParam[linha, coluna];
        }
    }

    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        Console.Write($"Soma da {linha + 1}° linha: {somaLinha[linha]}\n");
    }
}

void SomarColunaMatriz(int[,] matrizParam)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            somaColuna[coluna] += matrizParam[linha, coluna];
        }
    }

    for (int coluna = 0; coluna < qtdLinhas; coluna++)
    {
        Console.Write($"Soma da {coluna + 1}° coluna: {somaColuna[coluna]}\n");
    }
}

void SomarDiagonalPrincipalMatriz(int[,] matrizParam)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            if (linha == coluna)
            {
                somaDiagonal += matrizParam[linha, coluna];
            }
        }
    }

    Console.Write($"Soma da diagonal principal: {somaDiagonal}");
}

void SomarDiagonalSecundariaMatriz(int[,] matrizParam)
{
    for (int linha = 0; linha < qtdLinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdColunas; coluna++)
        {
            if (linha != coluna && linha + coluna == qtdLinhas - 1)
            {
                somaDiagonal2 += matriz[linha, coluna];
            }
        }
    }

    Console.Write($"Soma da diagonal secundária: {somaDiagonal2}");
}

CriarMatriz(matriz, inicio, fim);
ImprimirMatriz(matriz, "\nMatriz para operações");
Console.WriteLine();
Console.WriteLine();

int opcao = 0;
do
{
    opcao = Menu();
    switch (opcao)
    {
        case 1:
            SomarLinhaMatriz(matriz);
            break;

        case 2:
            SomarColunaMatriz(matriz);
            break;

        case 3:
            SomarDiagonalPrincipalMatriz(matriz);
            break;

        case 4:
            SomarDiagonalSecundariaMatriz(matriz);
            break;
        default:
            Console.WriteLine("\nÉ apenas um dos números sugeridos, tente novamente\n");
            break;
    }
} while ((opcao < 1) || (opcao > 4));
