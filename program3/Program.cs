// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int[] GetSquaresNumer(int numer)
{
    int[] cubeNumers = new int[numer];

    for (int i = 1; i <= numer; i++)
    {
        cubeNumers[i - 1] = i * i * i;
    }

    return cubeNumers;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] result = GetSquaresNumer(num);
for (int i = 0; i < result.Length; i++) {
    Console.WriteLine(result[i]);
}
