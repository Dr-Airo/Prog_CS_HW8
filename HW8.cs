// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int[,] numbers = new int[3, 4];
// FillArray(numbers);
// PrintArray(numbers);
// Console.WriteLine();
// SortToLower(numbers);
// PrintArray(numbers);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 11);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int p = 0; p < array.GetLength(1) -1 ; p++)
//             {
//                 if (array [i, p] < array[i, p + 1])
//                 {
//                     int temp = array[i, p + 1];
//                     array[i, p + 1] = array[i, p];
//                     array[i, p] = temp;
//                 }
//             }
//         }
//     }
// }
// __________________________________________________________________________________________________
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.WriteLine("Введите размер массива m x n и диапазон случайных значений:");
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");
// int range = InputNumbers("Введите диапазон: от 1 до ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");

// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }
// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }
// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }
// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] array = new int[rows, columns];
// int[,] secondArray = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];

// FillArray(array);
// PrintArray(array);

// Console.WriteLine();

// FillArray(secondArray);
// PrintArray(secondArray);

// Console.WriteLine();

// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array[i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray(resultArray);

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }

// // Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int arraySizeX = 2;
int arraySizeY = 2;
int arraySizeZ = 2;
int minNumber = 10;
int maxNumber = 99;
int[,,] testArray = new int[arraySizeX, arraySizeY, arraySizeZ];

Console.Clear();
FillArrayRandomNumber(testArray, minNumber, maxNumber);
PrintArrayWithIdex(testArray);

void FillArrayRandomNumber(int[,,] array, int minNumber = 0, int maxNumber = 9)
{
Random rand = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int h = 0; h < array.GetLength(2); h++)
        {
            while (array[i, j, h] == 0)
            {
                int number = rand.Next(minNumber, maxNumber + 1);
                if (IsNumberInArray(array, number) == false)
                {
                    array[i, j, h] = number;
                }
            }

        }
    }
}
}

bool IsNumberInArray(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }
    return false;
}

void PrintArrayWithIdex(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                Console.Write(array[i, j, h]);
                Console.Write("({0},{1},{2})\t", i, j, h);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int size = 4;
// int[,] spiral = new int[size, size];
// FillArraySpiral(spiral, size);
// PrintArray(spiral);

// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// void PrintArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }