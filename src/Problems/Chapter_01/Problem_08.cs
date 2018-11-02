using System;

namespace Problems.Chapter_01
{
    public class Problem_08
    {
        public static void ZeroMatrix(int[,] A)
        {
            int M = A.GetLength(0);
            int N = A.GetLength(1);

            bool[,] visited = new bool[M, N];

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                {
                    if (A[i, j] == 0 && !visited[i, j])
                    {
                        for (int k = 0; k < M; k++)
                        {
                            A[k, j] = 0;
                            visited[k, j] = true;
                        }
                        for (int k = 0; k < N; k++)
                        {
                            A[i, k] = 0;
                            visited[i, k] = true;
                        }
                    }
                }
        }
    }
}