using System;

namespace Test.Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cicle = true;
            while (cicle)
            {
                cicle = Gestione.Menu();
            }
        }
    }
}
