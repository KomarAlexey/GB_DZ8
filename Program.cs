// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Функция 1   Ввода оператора (числа) ,запрос данных.
// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }


// //Массив рандомных чисел функция
// int[,] FillArray(int numLine, int numColumns)
// {
//     Random rand = new Random();
//     int[,] matrix = new int[numLine, numColumns];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(1, 9);
//         }
//     }
//     return matrix;
// }

// //ввыводит массив функция .
// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintArray2(int[] matrix)
// {  
//         for (int j = 0; j < 4; j++)
//         {
//             Console.Write($"{matrix[j]}\t");
//         }
//         Console.WriteLine();
// }

// // int [,] array = FillArray(Prompt("Введите число строк > "),Prompt("Введите число столбцов > "));
// // Console.WriteLine("Заданный массив: ");
// // PrintArray(array);

// // for (int i = 0; i < array.GetLength(0); i++)
// //     for (int j = 0; j < array.GetLength(1); j++)
// //         for (int k = 0; k < array.GetLength(1); k++)
// //         {
// //             if (array[i, j] >= array[i, k])
// //             {
// //                 int temp = array[i, j];
// //                 array[i, j] = array[i, k];
// //                 array[i, k] = temp;
// //             }
// //         }
// // Console.WriteLine("Упорядоченный массив: ");
// // PrintArray(array);




// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 5 2 6 7
// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int line = 4; 
// int colums = 3;
// int [,] array = FillArray(line,colums );
// Console.WriteLine("Заданный массив: ");
// PrintArray(array);
// int sum = 0;
// int[] arraysum = new int [4];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         sum = array[i,j] + sum;
//     }
//     arraysum[i]= sum;
//     sum = 0;
// }
// PrintArray2(arraysum);
// int minLine= arraysum[0];
// int min = 1;
// for (int i = 1; i < line; i++)
// {
//     if (arraysum[i] < minLine)
//     {
//         minLine = arraysum[i];
//         min = i+1;
//     }
// }
// Console.WriteLine($"Строка с наименьшей сумму: {min}");


// Console.WriteLine();
// int minLine = matrix2[0];
// int minSum = 1;
// for (int k = 1; k < line; k++)
// {
//     if (matrix2[k]<minLine)
//     {
//         minLine = matrix2[k];
//         minSum = k+1;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void NewRandomMatrix (int[,]matrix)
// {
//     Random rand = new Random();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rand.Next(1,6);
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void TwoMatrixProduct (int[,] matrix1, int[,] matrix2)
// {
//     int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int ji = 0; ji < matrix2.GetLength(1); ji++)
//         {
//             for (int ka = 0; ka < matrix2.GetLength(0); ka++)
//             {
//                 matrix3[i, ji] += matrix1[i, ka] * matrix2[ka, ji];
//             }System.Console.Write($"{matrix3[i, ji]}\t");
//         }System.Console.WriteLine();
//     }
// }

// System.Console.WriteLine("Сколько строк должно быть в первой матрице");
// int str = int.Parse(Console.ReadLine()!);

// System.Console.WriteLine("Столько столбцов должно быть в первой матрице");
// int col = int.Parse(Console.ReadLine()!);

// int[,] firstMatrix = new int[str, col];
// int[,] secondMatrix = new int[col, str];

// System.Console.WriteLine("First matrix");
// NewRandomMatrix(firstMatrix);
// System.Console.WriteLine("Second matrix");
// NewRandomMatrix(secondMatrix);
// System.Console.WriteLine("product of two matrix");
// TwoMatrixProduct(firstMatrix, secondMatrix);
