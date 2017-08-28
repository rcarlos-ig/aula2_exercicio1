using System;
using System.Globalization;

namespace aula2_exercicio2 {
    class Funcionario {
        public string nome { get; private set; }
        public double salarioBruto { get; private set; }
        public double desconto { get; private set; }

        public Funcionario(string nome, double salarioBruto, double desconto) {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.desconto = desconto;
        }

        public double SalarioLiquido() {
            return salarioBruto - desconto;
        }
        public void AumentaSalario(double porcentagem) {
            salarioBruto = salarioBruto + (salarioBruto * porcentagem / 100.0);
        }
        public override string ToString() {
            return nome
                + ", R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
