using System;
using System.Globalization;

namespace fixacao1 {
    class Conta {
        public int numero;
        public string titular;
        public double saldo;

        public Conta(int numero, string titular, double valorInicial) {
            this.numero = numero;
            this.titular = titular;
            this.saldo = valorInicial;
        }

        public Conta(int numero, string titular) {
            this.numero = numero;
            this.titular = titular;
            saldo = 0.0;
        }

        public override string ToString() {
            return "Conta: "
                + numero
                + ", "
                + "Titular: "
                + titular
                + ", "
                + "Saldo: R$ "
                + saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
