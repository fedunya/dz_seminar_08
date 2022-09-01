// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

void PrintArray(int[,] array) {
    for (var i = 0; i < array.GetLength(0); i++) {
        for (var j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
int[,] FillArrayRandom(int m, int n) {
    int[,] result = new int[m,n];
    var random = new Random();
    for (var i = 0; i < result.GetLength(0); i++) {
        for (var j = 0; j < result.GetLength(1); j++) {
            result[i,j] = random.Next(1, 5);
        }
    }
    return result;
}
int IntParseInput(string str) {
ReadInput:
    Console.Write(str);
    var inputStringA = Console.ReadLine()!;
    if (!int.TryParse(inputStringA, out int num)) {
        Console.WriteLine("Введено не число!");
        goto ReadInput;
    }
    else return num;
}
int[,] MultiplyTwoMatrix(int[,] arrayA, int[,] arrayB)
{
    int[,] array = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
            for (int k = 0, l = 0; k < arrayA.GetLength(1); k++, l++)
            {
                array[i, j] = array[i, j] + arrayA[i, k] * arrayB[l, j];
            }
        }
    }
    return array;
}

Console.Clear();
int m = IntParseInput("Введите число строк массива (m): ");
int n = IntParseInput("Введите число столбцов массива (n): ");
var arrayA = FillArrayRandom(m, n);
var arrayB = FillArrayRandom(n, m);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();
PrintArray(MultiplyTwoMatrix(arrayA, arrayB));
