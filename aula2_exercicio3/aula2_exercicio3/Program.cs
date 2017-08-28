using System;
using System.Globalization;

namespace aula2_exercicio3 {
    class Program {
        static void Main(string[] args) {
            Aluno x;
            string nome;
            double nota1, nota2, nota3;

            Console.Write("Informe o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Informe a primeira nota do aluno: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a segunda nota do aluno: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a terceira nota do aluno: ");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x = new Aluno(nome, nota1, nota2, nota3);

            Console.WriteLine();
            Console.WriteLine("Nota Final: " + x.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (x.Aprovado()) {
                Console.Write("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                Console.Write("Faltaram " + x.PontosFaltantes().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
            }
            Console.ReadLine();
        }
    }
}
