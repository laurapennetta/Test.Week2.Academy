using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week2
{
    public class MovimentoTransfert<T> where T : IMovimento
    {
        public Banca BancaOrigine { get; set; }
        public Banca BancaDestinazione { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }

        public MovimentoTransfert(double importo, DateTime data, Banca origine, Banca destinazione)
        {
            Importo = importo;
            DataMovimento = data;
            BancaOrigine = origine;
            BancaDestinazione = destinazione;
        }
        public override string ToString()
        {
            return $"-MOVIMENTO TRANSFERT: Importo: {Importo} - Data: {DataMovimento} - Banca d'Origine: {BancaOrigine} - Banca di Destinazione: {BancaDestinazione}";
        }
    }
}
