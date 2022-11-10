// В двумерном массиве целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент

int[,] matrix1 = {
    { 2, 3, 6, 3 },
    { 2, 7, 2, 3 },
    { 2, 3, 6, 3 },
    { 1, 3, 6, 4 }
};

int[,] DeleteColumnRow(int[,] matr1)
{

    // найти координаты наименьшего числа в массиве
    int minValue = matr1[0, 0];
    int minRow = 0;
    int minCol = 0;

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            if (matr1[i, j] < minValue)
            {
                minValue = matr1[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }


    // наполнить новый массив всеми элементами, пропуская элементы имеющие столбец или строку, равную найденным на предыдущем этапе
    int[,] matr = new int[matr1.GetLength(0) - 1, matr1.GetLength(1) - 1];
    int k = 0;
    int n = 0;

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            if(i != minRow && j != minCol) {
                matr[k,n] = matr1[i, j];
                n++;
            }
        }
        n = 0;
        if(i != minRow) {
            k++;
        }
    }
    return matr;
}


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(DeleteColumnRow(matrix1));