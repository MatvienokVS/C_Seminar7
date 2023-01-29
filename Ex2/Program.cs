//Напишите программу реализующую метод, принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

using static System.Console;
Clear();

Write("Введите параметры массива и искомое значение через пробел: ");

int[] ints = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

Write("Введите искомое значение: ");
int.TryParse(ReadLine()!, out int searchnum);

int[,] array = GetDDArray(ints[0], ints[1], ints[2], ints[3]);

PrintDDArray(array);
SearchNumber(array, searchnum);




int[,] GetDDArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] Array = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Array[i, j] = rnd.Next(minValue, maxValue + 1);
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

int SearchNumber(int[,] inArray, int num)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (array[i, j] == num)
                WriteLine($"Элемент с координатами [{i},{j}] равный {inArray[i,j]} совпадает с искомым");
            else
                WriteLine($"Элемент [{i},{j}] не совпадает с искомым");
        }
    }
    return num;
}
