namespace VetoreExercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePessoas = int.Parse(Console.ReadLine());
            string[] pessoas = new string[quantidadePessoas];
            int[] idades = new int[quantidadePessoas];

            for (int i = 0; i < pessoas.Length; i++)
            {
                string[] pessoa = Console.ReadLine().Split();
                pessoas[i] = pessoa[0];
                idades[i] = int.Parse(pessoa[1]);
            }

            int countMaioridade = 0;
            
            for (int i = 1; i < idades.Length; i++) {
                if (!(idades[i] < idades[countMaioridade])) {
                    countMaioridade++;
                }
                else {
                    countMaioridade++;
                }
            }
            Console.WriteLine("Pessoa mais velha: {0}", pessoas[countMaioridade]);
        }
    }
}
