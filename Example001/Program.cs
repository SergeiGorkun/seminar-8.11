// Найти произведение двух матриц

int[,] matrix1 = {
    { 1, 2, 6, 3 },
    { 9, 7, 3, 2 },
    { 2, 3, 1, 3 },
    { 5, 3, 6, 5 }
};

int[,] matrix2 = {
    { 2, 3, 6, 3 },
    { 2, 7, 2, 3 },
    { 2, 3, 6, 3 },
    { 1, 3, 6, 4 }
};

int [,] ProductwoMatrices(int [,] matr1, int [,] matr2){
    int [,] matr  = new int [matr1.GetLength(0),matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++){
            matr[i,j] = matr1[i,j] * matr2[i,j];
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
            Console.Write(matr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(ProductwoMatrices(matrix1, matrix2));