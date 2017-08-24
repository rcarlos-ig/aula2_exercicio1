using System;
using System.Globalization;

namespace aula2_exercicio1 {
    class Program {
        static void Main(string[] args) {
            Retangulo x = new Retangulo();
            double area, perimetro, diagonal;

            Console.Write("Informe a largura do retângulo: ");
            x.largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Informe a altura do retângulo: ");
            x.altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = x.Area();
            perimetro = x.Perimetro();
            diagonal = x.Diagonal();

            Console.WriteLine();
            Console.WriteLine("Largura: " + x.largura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Altura: " + x.altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Área: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + perimetro.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + diagonal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
