using System;

namespace Course {
    class Matriz {
        static void Main(string[] args) {

            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (int m = 0; m < M; m++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int n = 0; n < N; n++) {
                    mat[m, n] = int.Parse(values[n]);
                }
            }
            
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] == n1) {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < N - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < M - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}