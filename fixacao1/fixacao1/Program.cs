﻿using System;
using System.Globalization;

namespace fixacao1 {
    class Program {
        static void Main(string[] args) {
            Conta x;

            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 's') {
                Console.Write("Digite o valor do depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            } else {
                x = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Conta criada: ");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(deposito);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(x);

            Console.WriteLine();
            Console.Write("Digite um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saque);
            Console.WriteLine("Conta atualizada:");
            Console.WriteLine(x);


            Console.ReadLine();
        }
    }
}
