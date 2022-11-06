namespace MatrizExercicio1 { 
        
    class Program { 

        static void Main(string[] args) {

            int row, col;
            int[,] matriz;
            string[] matriz_p = Console.ReadLine().Split(" ");
            row = int.Parse(matriz_p[0]);
            col = int.Parse(matriz_p[1]);
            matriz = new int[row, col];

            for (int i = 0; i < row; i++) {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < s.Length; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }
            Console.WriteLine("Numeros negativos");
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (matriz[i, j] < 0) {
                        Console.Write(matriz[i, j]);
                    };
                }
            }
        }
    }
}
