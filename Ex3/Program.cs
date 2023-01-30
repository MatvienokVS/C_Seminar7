//Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


using static System.Console;
Clear();

Write("Введите параметры массива: ");

int[] ints = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

int[,] array = GetDDArray(ints[0], ints[1], ints[2], ints[3]);

PrintDDArray(array);
PrintAverageArray(AverageNumber(array));

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
			Write($"{inArrai[i, j],4}");
		}
		WriteLine();
	}

}

double[] AverageNumber(int[,] inArray)
{
	double[] average = new double[inArray.GetLength(1)];

	for (int i = 0; i < inArray.GetLength(1); i++)
	{
		for (int j = 0; j < inArray.GetLength(0); j++)
		{
			average[i] += inArray[j, i];
		}
		average[i] /= inArray.GetLength(1);
		//Write($"{average[i] / inArray.GetLength(0),6}");
	}
	return average;
}


void PrintAverageArray(double[] array)
{
	Write("[");

	for (int i = 0; i < array.Length - 1; i++)
	{
		Write($"{array[i]}, ");
	}

	Write($"{array[array.Length - 1]}");
	Write("]");
	WriteLine();
}
