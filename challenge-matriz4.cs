namespace MatrizExercicio1 
    class Program 

        static void Main(string[] args) 

            int value = int.Parse(Console.ReadLine());
            int[,] matriz = new int[value, value];
            for (int i = 0; i < value; i++) {
                string[] s = Console.ReadLine().Split(" ");
                for (int j = 0; j < s.Length; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            for (int i = 0; i < value; i++) {
                int countMaioridade = 0;
                for (int j = 1; j < value; j++) {
                    if (!(matriz[i, j] < matriz[i, countMaioridade])){
                        countMaioridade++;
                    }
                Console.WriteLine(matriz[i, countMaioridade]);
                }
            }
        }
    }
}
