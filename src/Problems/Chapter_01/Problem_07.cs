using System;

namespace Problems.Chapter_01
{
    public class Problem_07
    {
        public static void RotateMatrix(int[,] matrix)
        {
            int N = matrix.GetLength(0);

            for (int i = 0; i < N / 2; i++)
                for (int j = i; j < N - 1 - i; j++)
                {
                    int nw = matrix[i          , j          ];
                    int ne = matrix[j          , N - (i + 1)];
                    int se = matrix[N - (i + 1), N - (j + 1)];
                    int sw = matrix[N - (j + 1), i          ];

                    matrix[i          , j          ] = ne;
                    matrix[j          , N - (i + 1)] = se;
                    matrix[N - (i + 1), N - (j + 1)] = sw;
                    matrix[N - (j + 1), i          ] = nw;
                }
        }
    }
}