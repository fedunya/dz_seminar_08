// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void PrintArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArrayRandom() {
    var random = new Random();
    int m = random.Next(3, 8);
    int n = m - 1;
    int[,] result = new int[m, n];
    for (var i = 0; i < result.GetLength(0); i++) {
        for (var j = 0; j < result.GetLength(1); j++) {
            result[i,j] = random.Next(1, 10);
        }
    }
    return result;
}
int LineWithMinSumElements(int[,] array)
{
    int indexLine = 0;
    int sumLine = 9 * array.GetLength(1);;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < sumLine)
        {
            sumLine = sum;
            indexLine = i+1;
        }
    }
    return indexLine;
}

Console.Clear();
var result = FillArrayRandom();
PrintArray(result);
Console.WriteLine();
Console.Write("Номер строки с наименьшей суммой элементов: ");
Console.WriteLine(LineWithMinSumElements(result));
