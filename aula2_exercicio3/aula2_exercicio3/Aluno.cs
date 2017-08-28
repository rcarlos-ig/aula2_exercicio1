using System;
using System.Globalization;

namespace aula2_exercicio3 {
    class Aluno {
        public string nome { get; private set; }
        public double nota1 { get; private set; }
        public double nota2 { get; private set; }
        public double nota3 { get; private set; }

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double NotaFinal() {
            return nota1 + nota2 + nota3;
        }
        public bool Aprovado() {
            if (NotaFinal() < 60.0) {
                return false;
            } else {
                return true;
            }
        }
        public double PontosFaltantes() {
            return 60.0 - NotaFinal();
        }
    }
}
