// Майборода А.А. Вар 3 - Высокий уровень
double SqrtK(double x, int k, int n)
{
    if (n == 0) return 1;
    return SqrtK(x, k, n - 1) - (SqrtK(x, k, n - 1) - x / Math.Pow(SqrtK(x, k, n - 1), k - 1)) / k;
}

for (var nValue = 1; nValue <= 6; nValue++)
    Console.WriteLine(SqrtK(64, 6, nValue * 2));