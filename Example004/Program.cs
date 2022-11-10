// Показать треугольник Паскаля. * Сделать вывод в виде равнобедренного треугольника
void PascalTriangleProgram(int N)
{
    for (int i = 0; i < N; i++)
    {
        int C = 1;
        for (int j = 0; j < N - i; j++)
        {
            Console.Write("   ");
        }

        for (int k = 0; k <= i; k++)
        {
            Console.Write("    {0:D} ", C);
            C = C * (i - k) / (k + 1);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число:  ");
string input = Console.ReadLine();
int N = Convert.ToInt32(input);
PascalTriangleProgram(N);
