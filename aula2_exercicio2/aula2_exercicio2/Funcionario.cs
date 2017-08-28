using System;
using System.Globalization;

namespace aula2_exercicio2 {
    class Funcionario {
        public string nome;
        public double salarioBruto, desconto;

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
