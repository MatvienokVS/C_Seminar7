//Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Write("Введите параметры массива и искомое значение через пробел: ");

int[] ints = Array.ConvertAll(ReadLine()!.Split(new char[] { ' ', '.', ',', ';', ':' }, StringSplitOptions.RemoveEmptyEntries), int.Parse);

Write("Введите искомое значение: ");
int.TryParse(ReadLine()!, out int searchnum);

int[,] array = GetDDArray(ints[0], ints[1], ints[2], ints[3]);

PrintDDArray(array);
AverageNumber(array);

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

double AverageNumber(int[,] inArray)
{
	double summ = 0;									// Сумма элементов по столбцам
	
	double[] array2 = new double[inArray.Length];		// Cоздаём одномерный массив для записи среднего арифметического по столбцам.

	for (int i = 0; i < inArray.GetLength(1); i++)		//Проходим по столбцу
	{
		for (int j = 0; j < inArray.GetLength(0); j++)	// Проходим по строке
		{
			summ += inArray[i, j];						// Сумируем элементы в столбце
			array2 = summ / inArray.GetLength(0);		// Вычисляем среднее арифметическое
		}
	}	
	return array2;										// Возвращаем обномерный массив
}
