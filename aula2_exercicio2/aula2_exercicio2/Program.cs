using System;
using System.Globalization;

namespace aula2_exercicio2 {
    class Program {
        static void Main(string[] args) {
            Funcionario x;
            string nome;
            double salarioBruto, desconto, porcentagem;

            Console.Write("Informe o nome do funcionário: ");
            nome = Console.ReadLine();
            Console.Write("Informe o salário bruto do funcionário: ");
            salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe o desconto do salário do funcionário: ");
            desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            x = new Funcionario(nome, salarioBruto, desconto);

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
