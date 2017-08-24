using System;
using System.Globalization;

namespace aula2_exercicio3 {
    class Aluno {
        public string nome;
        public double nota1, nota2, nota3;

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
