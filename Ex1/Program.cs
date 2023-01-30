//Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 - 2 - 0,2
//1 - 3,3 8 - 9,9
//8 7,8 - 7,1 9

using static System.Console;
Clear();

Write("Введите параметры массива: ");

int[] ints = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetDDArray(ints[0], ints[1], ints[2], ints[3]);
PrintDDArray(array);



int[,] GetDDArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] Array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return Array;
}

void PrintDDArray(int[,] inArrai)
{
    for (int i = 0; i < inArrai.GetLength(0); i++)
    {
        for (int j = 0; j < inArrai.GetLength(1); j++)
        {
            Write($"{inArrai[i, j],5}");
        }
        WriteLine();
     }

}
