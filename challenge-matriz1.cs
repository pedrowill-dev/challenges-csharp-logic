using System.Globalization;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] A;
            row = int.Parse(Console.ReadLine());
            col = int.Parse(Console.ReadLine());
            A = new int[row, col];

            for (int i = 0; i < row; i++) {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < col; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < row; i++){
                for (int j = 0; j < col; j++){
                    Console.Write(A[i, j] + " ");
                }
            }

        }
    }
}
