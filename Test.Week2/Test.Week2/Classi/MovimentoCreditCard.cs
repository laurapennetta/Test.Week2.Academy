using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week2
{
    public enum Carta
    {
        Amex, 
        Visa, 
        Mastercard, 
        Other
    }
    public class MovimentoCreditCard<T> where T : IMovimento
    {
        public string NumeroCarta { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }
        public Carta TipoCarta { get; set; }
        public MovimentoCreditCard(double importo, DateTime data, string numero, Carta carta)
        {
            Importo = importo;
            DataMovimento = data;
            NumeroCarta = numero;
            TipoCarta = carta;
        }
        public override string ToString()
        {
            return $"-MOVIMENTO CREDIT CARD: Importo: {Importo} - Data: {DataMovimento} - Numero di Carta: {NumeroCarta} - Tipo Carta: {TipoCarta}";
        }
    }
}
