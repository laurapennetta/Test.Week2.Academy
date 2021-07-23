using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week2
{
    public enum Banca
    {
        Unicredit_Spa,
        Monte_dei_Paschi_di_Siena_Spa,
        Intesa_SanPaolo_Spa,
        Banco_Popolare
    }
    public class Account
    {
        public string NumeroConto { get; set; }
        public Banca NomeBanca { get; set; }
        public double Saldo { get; set; }
        public DateTime DataOperazione { get; set; }
        public List<IMovimento> Movimenti { get; set; }
        public Account() { }
        public Account(string numConto, Banca nomeBanca, double saldo, DateTime data)
        {
            NumeroConto = numConto;
            NomeBanca = nomeBanca;
            Saldo = saldo;
            DataOperazione = data;
        }

        public static Account operator +(Account a, IMovimento m)
        {
            a.Saldo += m.Importo;
            a.DataOperazione = DateTime.Now;
            return a;
        }
        public static Account operator -(Account a, IMovimento m)
        {
            a.Saldo -= m.Importo;
            a.DataOperazione = DateTime.Now;
            return a;
        }

        public override string ToString()
        {
            return $"Numero Conto: {NumeroConto}\nNome Banca: {NomeBanca}\nSaldo: {Saldo}\nData dell' ultima operazione: {DataOperazione}\n\n\nMOVIMENTI:\n{Movimenti}";
        }
    }
}
