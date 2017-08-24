using System;
using System.Globalization;

namespace aula2_exercicio3 {
    class Program {
        static void Main(string[] args) {
            Aluno x = new Aluno();

            Console.Write("Informe o nome do aluno: ");
            x.nome = Console.ReadLine();
            Console.Write("Informe a primeira nota do aluno: ");
            x.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a segunda nota do aluno: ");
            x.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a terceira nota do aluno: ");
            x.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

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
