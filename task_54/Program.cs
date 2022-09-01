// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
            result[i,j] = random.Next(1, 10);
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
int[,] SortLines(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {       
        int start = 0;
        while (start < array.GetLength(1))
        {
            int max = 0;
            int indexMax = 0;
            for (int j = start; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                    indexMax = j;                    
                }                                     
            }
            temp = array[i, start];
            array[i, start] = max;
            array[i, indexMax] = temp;            
            start++;   
        }
    }
    return array;
}

Console.Clear();
int m = IntParseInput("Введите число строк массива (m): ");
int n = IntParseInput("Введите число столбцов массива (n): ");
var result = FillArrayRandom(m, n);
PrintArray(result);
Console.WriteLine();
PrintArray(SortLines(result));
