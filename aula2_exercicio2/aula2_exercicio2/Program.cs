using System;
using System.Globalization;

namespace aula2_exercicio2 {
    class Program {
        static void Main(string[] args) {
            Funcionario x = new Funcionario();
            double porcentagem;

            Console.Write("Informe o nome do funcionário: ");
            x.nome = Console.ReadLine();
            Console.Write("Informe o salário bruto do funcionário: ");
            x.salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o desconto do salário do funcionário: ");
            x.desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do funcionário: " + x);
            Console.Write("Deseja aumentar o salário em qual porcentagem: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.AumentaSalario(porcentagem);
            Console.WriteLine("Dados do funcionário: " + x);
            Console.ReadLine();
        }
    }
}
