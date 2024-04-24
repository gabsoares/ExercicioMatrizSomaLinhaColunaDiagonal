int qtdLinhas = 4, qtdColunas = 4;
int[,] matriz = new int[qtdLinhas, qtdColunas];
int[] somaLinha = new int[6];
int[] somaColuna = new int[6];
int somaDiagonal = 0, somaDiagonal2 = 0;

for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        matriz[linha, coluna] = new Random().Next(1, 10);
    }
}
for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        Console.Write(matriz[linha, coluna] + " ");
    }
}
Console.WriteLine();

//Soma de linha
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        somaLinha[linha] += matriz[linha, coluna];
    }
}
//Soma de coluna
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        somaColuna[coluna] += matriz[linha, coluna];
    }
}

//Soma diagonal principal
for (int linha = 0; linha < qtdLinhas; linha++)
{
    for (int coluna = 0; coluna < qtdColunas; coluna++)
    {
        if (linha == coluna)
        {
            somaDiagonal += matriz[linha, coluna];
        }
    }
}

//Soma diagonal secundária
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

Console.WriteLine();

for (int linha = 0; linha < qtdLinhas; linha++)
{
    Console.Write($"Soma da {linha + 1}° linha: {somaLinha[linha]}\n");
}

Console.WriteLine();

for (int coluna = 0; coluna < qtdLinhas; coluna++)
{
    Console.Write($"Soma da {coluna + 1}° coluna: {somaColuna[coluna]}\n");
}

Console.WriteLine();
Console.Write($"Soma da diagonal principal: {somaDiagonal}");

Console.WriteLine();

Console.Write($"Soma da diagonal secundária: {somaDiagonal2}");