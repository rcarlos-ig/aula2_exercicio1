using System;

namespace aula2_exercicio1 {
    class Retangulo {
        public double largura, altura;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro() {
            return 2 * (largura + altura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }
    }
}
