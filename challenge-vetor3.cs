
using System.Globalization;

namespace VetoreExercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadePessoas = int.Parse(Console.ReadLine());
            double[] alturas  = new double[quantidadePessoas];
            char[] sexo = new char[quantidadePessoas];

            for (int i = 0; i < quantidadePessoas; i++) {
                string[] pessoa = Console.ReadLine().Split();
                alturas[i] = double.Parse(pessoa[0], CultureInfo.InvariantCulture);
                sexo[i] = char.Parse(pessoa[1]);
            }

            int countMinoridade = 0;
            int countMaioridade = 0;
            double media = 0.0;
            int countMulheres = 0;
            int countHomens = 0;

            for (int i = 1; i < quantidadePessoas; i++) {
                if (alturas[i] < alturas[countMinoridade]) {
                    countMinoridade++;
                }
            }

            for (int i = 1; i < quantidadePessoas; i++) {
                if (!(alturas[i] < alturas[countMaioridade])) {
                    countMaioridade++;
                }
            }

            for (int i = 0; i < quantidadePessoas; i++) {
                if (sexo[i] == 'F') {
                    media += alturas[i];
                    countMulheres++;
                } else {
                    countHomens++;
                }
            }

            media = media / countMulheres;

            Console.WriteLine("Menor altura: {0}", alturas[countMinoridade].ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Maior altura: {0}", alturas[countMaioridade].ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Média das alturas das mulheres: {0}", media.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Numero de homens: {0}", countHomens);

        }
    }
}
