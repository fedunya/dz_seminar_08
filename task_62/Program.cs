// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4; // Решение общее для квадратных массивов. Значение 4 под конкретную задачу

void PrintArray(int[,] array) {
        for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j], 2} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArraySpiral(int n)
{
    int value = 1;
    int[,] array = new int[n, n];
    for (int i = 0; i < n / 2 + n % 2; i++)
    {
        for (int j = i; j < n-i; j++)
        {
            array[i, j] = value;
            value++;
        }
        for (int k = i + 1; k < n - i; k++)
        {
            array[k, n - i - 1] = value;
            value++;
        }
        for (int l = n - i - 2; l >= i; l--)
        {
            array[n - i - 1, l] = value;
            value++;
        }
        for (int m = n - i - 2; m > i; m--)
        {
            array[m, i] = value;
            value++;
        }
        
    }    
    return array;
}

PrintArray(FillArraySpiral(n));
