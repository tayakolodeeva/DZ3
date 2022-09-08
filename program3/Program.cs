// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int[] GetPositiveSquaresNumer(int numer)
{
    int[] cubeNumers = new int[numer];

    for (int i = 1; i <= numer; i++)
        {
        cubeNumers[i - 1] = i * i * i;
        }

    return cubeNumers;
}
int[] GetNegativeSquaresNumer(int numer)
{
    numer = numer * -1;
    int[] cubeNumers = new int[numer*1];

    for (int i = 1; i <= numer; i++)
        {
        cubeNumers[i - 1] = i * i * i * -1;
        }

    return cubeNumers;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num>0)
{
    int[] result = GetPositiveSquaresNumer(num);
    for (int i = 0; i < result.Length; i++)
    {
    Console.WriteLine(result[i]);
    }
}
else
{
    int[] result = GetNegativeSquaresNumer(num);
    for (int i = 0; i < result.Length; i++)
    {
    Console.WriteLine(result[i]);
    }
}