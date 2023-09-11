using System;

namespace Homework8
{
    internal class Program
    {
        static void PrintArry2D(int[,] arr)
        {
            for(int i=0; i <arr.GetLength(0); i++)
            {
                for(int j=0; j <arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        static int[,] SortedArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] sortedArr = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                int[] row = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    row[j] = array[i, j];
                }
                Array.Sort(row);
                Array.Reverse(row);
                for (int j = 0; j < cols; j++)
                {
                    sortedArr[i, j] = row[j];
                }
            }
            return sortedArr;
        }

        static void Task54()
        {
            int n, m;
            n = Convert.ToInt32(Console.ReadLine());
            m = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = num;
                }
            }
            arr = SortedArray(arr);
            PrintArry2D(arr);
        }

        static void Task56()
        {
            int[,] arr = {
                {1, 4, 7, 2 },
                {5, 9, 2, 3 },
                {8, 4, 2, 4 },
                {5, 2, 6, 7 }
            };
            int n, m;
            n = 4;
            m = 4;
            int minRow = 1;
            int minSum = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];
                }
                if (i == 0)
                {
                    minSum = sum;
                }
                else if (minSum > sum)
                {
                    minSum = sum;
                    minRow = i + 1;
                }
            }

            Console.WriteLine(minRow);
        }

        static void Task58()
        {
            int[,] matrix1 =
            {
                {2,4},
                {3,2}
            };
            int[,] matrix2 =
            {
                {3,4},
                {3,3}
            };

            if(matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Матрицы нельзя перемножить");
                return;
            }
            int[,]result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for(int i=0; i<matrix1.GetLength(0); i++)
            {
                for(int j=0; j<matrix2.GetLength(1); j++)
                {
                    for(int k=0; k<matrix1.GetLength(1); k++)
                    {
                        result[i,j] += (matrix1[i,k] * matrix2[k,j]);
                    }
                }
            }
            Console.WriteLine("Результат:");
            PrintArry2D(result);
        } 

        static void Task60()
        {
            int[,,]arr = new int[2,2,2];
            for(int i=0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    for(int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write(arr[i, j, k] + "("+i+","+j+","+k+")");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Task62()
        {
            int n = 4;
            int[,] arr = new int[n, n];
            int num = 1;
            int row = 0, col = 0;

            int minRow = 0, minCol = 0;
            int maxRow = n - 1, maxCol = n - 1;
            while (num <= n * n)
            {
                // Вправо.
                for (col = minCol; col <= maxCol; col++)
                {
                    arr[minRow, col] = num++;
                }
                minRow++;

                // Вниз.
                for (row = minRow; row <= maxRow; row++)
                {
                    arr[row, maxCol] = num++;
                }
                maxCol--;

                // Влево.
                for (col = maxCol; col >= minCol; col--)
                {
                    arr[maxRow, col] = num++;
                }
                maxRow--;

                // Вверх.
                for (row = maxRow; row >= minRow; row--)
                {
                    arr[row, minCol] = num++;
                }
                minCol++;
            }

            for(int i =0; i < n; i++)
            {
                for(int j=0; j < n; j++)
                {
                    if (arr[i, j] < 10)
                    {
                        Console.Write("0" + arr[i, j]+" ");
                    }
                    else
                    {
                        Console.Write(arr[i, j]+" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Task62();
        }
    }
}