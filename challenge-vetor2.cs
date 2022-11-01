using System.Globalization;

namespace VetoreExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeAlunos = int.Parse(Console.ReadLine());

            double[] bimestre1 = new double[quantidadeAlunos];
            double[] bimestre2 = new double[quantidadeAlunos];
            string[] alunos = new string[quantidadeAlunos];
            
            for (int i = 0; i < quantidadeAlunos; i++) {
                string[] aluno = Console.ReadLine().Split(" ");
                alunos[i] = aluno[0];
                bimestre1[i] = double.Parse(aluno[1], CultureInfo.InvariantCulture);
                bimestre2[i] = double.Parse(aluno[2], CultureInfo.InvariantCulture);           
            }

            for (int i = 0; i < quantidadeAlunos; i++) {
                double media = 0.0;
                media = bimestre1[i] + bimestre2[i] / quantidadeAlunos;
                if (media >= 6) {
                    Console.Write("\n Aluno aprovado: {0}", alunos[i]);
                } else {
                    Console.Write("\n Aluno reprovado: {0}", alunos[i]);
                }
            }
        }
    }
}
