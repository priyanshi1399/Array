using System.Numerics;

namespace _48._Rotate_Image
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Brute Force Approach
            //int[][] matrix = { [1, 2, 3], [4, 5, 6], [7, 8, 9] };
            //int temp = 0;
            //int n = matrix.Length;
            //int m = matrix[0].Length;           
            //int[][] matrix2=new int[n][];
            //for (int i = 0; i < n; i++)
            //{
            //    matrix2[i]=new int[n];
            //}
            //for(int i = 0; i < n; i++)
            //{
            //    for(int j = 0; j < m; j++)
            //    {
            //        matrix2[i][j] = 0;
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        matrix2[j][((n - 1) - i)] = matrix[i][j];

            //    }
            //} 

            //for (int i = 0; i < matrix2.Length; i++)
            //{
            //    for (int j = 0; j < matrix2[i].Length; j++)
            //    {
            //        matrix[i][j] = matrix2[i][j];
            //    }
            //}


            #endregion

            int temp = 0;
            int[][] matrix = new int[][]
            {
                new int[]{1,2,3 },
                new int[]{4,5,6},
                new int[]{7,8,9},
            };
            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = i + 1; j < matrix[i].Length; j++)
                {
                     temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }
            for(int i = 0;i < matrix.Length; i++)
            {
                Array.Reverse(matrix[i]);
            }

        }
    }
    }

