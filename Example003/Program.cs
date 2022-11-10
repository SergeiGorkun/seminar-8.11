// Сформировать трехмерный массив не повторяющимися двузначными числами, показать его построчно на экран выводя индексы соответствующего элемента
int[,,] array = new int[3, 3, 3];



int[,,] FillArray(int[,,] arr)
{
    List<int> uniqueArr = new List<int>();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
                int rnd = GetUniqueRandomValue(uniqueArr);
                arr[i, j, k] = rnd;
                uniqueArr.Add(rnd);
            }
        }
    }
    return arr;
}


void PrintArray(int[,,] array)
{
     for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 3; k++)
            {
               Console.WriteLine("Элемент с индексами " + i + ", " + j + ", " + k + " равен " + array[i,j,k]);
            }
        }
    }
}

// функция, которая генерирует случайное число, которое еще не было сгенерировано до этого
int GetUniqueRandomValue(List<int> arr)
{
    int rnd;
    while (true)
    {
        bool flag = true;
        rnd = (new Random()).Next(10, 99);
        foreach (int el in arr)
        {
            if(el == rnd) {
                flag=false;
            }
        }
        if(flag == true) {
            return rnd;
        }
    }
}

FillArray(array);
PrintArray(array);