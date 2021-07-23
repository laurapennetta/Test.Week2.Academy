using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week2
{
    public class MovimentoCash<T> where T : IMovimento
    {
        public string Esecutore { get; set; }
        public double Importo { get; set; }
        public DateTime DataMovimento { get; set; }
        public MovimentoCash(double importo, DateTime data, string esecutore)
        {
            Importo = importo;
            DataMovimento = data;
            Esecutore = esecutore;
        }

        public MovimentoCash()
        {
        }

        public override string ToString()
        {
            return $"-MOVIMENTO CASH: Importo: {Importo} - Data: {DataMovimento} - Esecutore: {Esecutore}";
        }
    }
}
