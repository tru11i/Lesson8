// Task 1

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4}
//         };

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         SortArray(array);

//         Console.WriteLine("Массив после упорядочивания:");
//         PrintArray(array);
//     }

//     static void PrintArray(int[,] arr)
//     {
//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     static void SortArray(int[,] arr)
//     {
//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             int[] rowArray = new int[cols];
//             for (int j = 0; j < cols; j++)
//             {
//                 rowArray[j] = arr[i, j];
//             }

//             Array.Sort(rowArray, (a, b) => b.CompareTo(a));

//             for (int j = 0; j < cols; j++)
//             {
//                 arr[i, j] = rowArray[j];
//             }
//         }
//     }
// }

// Task2

// class Program
// {
//     static void Main()
//     {
//         int[,] array = {
//             {1, 4, 7, 2},
//             {5, 9, 2, 3},
//             {8, 4, 2, 4},
//             {5, 2, 6, 7}
//         };

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         int minSumRowIndex = FindRowWithMinSum(array);

//         Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
//     }

//     static void PrintArray(int[,] arr)
//     {
//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(arr[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
//     static int FindRowWithMinSum(int[,] arr)
//     {
//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         int minSum = int.MaxValue;
//         int minSumRowIndex = -1;

//         for (int i = 0; i < rows; i++)
//         {
//             int currentSum = 0;

//             for (int j = 0; j < cols; j++)
//             {
//                 currentSum += arr[i, j];
//             }

//             if (currentSum < minSum)
//             {
//                 minSum = currentSum;
//                 minSumRowIndex = i;
//             }
//         }

//         return minSumRowIndex;
//     }
// }

// Task3

// class Program
// {
//     static void Main()
//     {
//         int[,] matrix1 = {
//             {2, 4},
//             {3, 2}
//         };

//         int[,] matrix2 = {
//             {3, 4},
//             {3, 3}
//         };

//         Console.WriteLine("Исходная матрица 1:");
//         PrintMatrix(matrix1);

//         Console.WriteLine("Исходная матрица 2:");
//         PrintMatrix(matrix2);

//         int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

//         Console.WriteLine("Результирующая матрица:");
//         PrintMatrix(resultMatrix);
//     }

//     static void PrintMatrix(int[,] matrix)
//     {
//         int rows = matrix.GetLength(0);
//         int cols = matrix.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write(matrix[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }

//     static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
//     {
//         int rows1 = matrix1.GetLength(0);
//         int cols1 = matrix1.GetLength(1);
//         int rows2 = matrix2.GetLength(0);
//         int cols2 = matrix2.GetLength(1);

//         if (cols1 != rows2)
//         {
//             throw new InvalidOperationException("Нельзя умножить матрицы с такими размерами");
//         }

//         int[,] resultMatrix = new int[rows1, cols2];

//         for (int i = 0; i < rows1; i++)
//         {
//             for (int j = 0; j < cols2; j++)
//             {
//                 for (int k = 0; k < cols1; k++)
//                 {
//                     resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
//                 }
//             }
//         }

//         return resultMatrix;
//     }
// }

// Task4

// class Program
// {
//     static void Main()
//     {
//         int[,,] threeDimArray = Generate3DArray(2, 2, 2);

//         Print3DArrayWithIndices(threeDimArray);
//     }

//     static int[,,] Generate3DArray(int dim1, int dim2, int dim3)
//     {
//         int[,,] array = new int[dim1, dim2, dim3];
//         int currentNumber = 10; 

//         for (int i = 0; i < dim1; i++)
//         {
//             for (int j = 0; j < dim2; j++)
//             {
//                 for (int k = 0; k < dim3; k++)
//                 {
//                     array[i, j, k] = currentNumber++;
//                 }
//             }
//         }

//         return array;
//     }

//     static void Print3DArrayWithIndices(int[,,] array)
//     {
//         int dim1 = array.GetLength(0);
//         int dim2 = array.GetLength(1);
//         int dim3 = array.GetLength(2);

//         for (int i = 0; i < dim1; i++)
//         {
//             for (int j = 0; j < dim2; j++)
//             {
//                 for (int k = 0; k < dim3; k++)
//                 {
//                     Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }

// Task5

// class Program
// {
//     static void Main()
//     {
//         int n = 4;

//         int[,] spiralArray = FillSpiralArray(n);

//         PrintArray(spiralArray);
//     }

//     static int[,] FillSpiralArray(int n)
//     {
//         int[,] array = new int[n, n];
//         int value = 1;

//         int left = 0, right = n - 1, top = 0, bottom = n - 1;

//         while (left <= right && top <= bottom)
//         {
//             for (int i = left; i <= right; i++)
//             {
//                 array[top, i] = value++;
//             }
//             top++;

//             for (int i = top; i <= bottom; i++)
//             {
//                 array[i, right] = value++;
//             }
//             right--;

//             if (top <= bottom)
//             {
//                 for (int i = right; i >= left; i--)
//                 {
//                     array[bottom, i] = value++;
//                 }
//                 bottom--;
//             }

//             if (left <= right)
//             {
//                 for (int i = bottom; i >= top; i--)
//                 {
//                     array[i, left] = value++;
//                 }
//                 left++;
//             }
//         }

//         return array;
//     }

//     static void PrintArray(int[,] arr)
//     {
//         int rows = arr.GetLength(0);
//         int cols = arr.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 Console.Write($"{arr[i, j]:D2} ");
//             }
//             Console.WriteLine();
//         }
//     }
// }