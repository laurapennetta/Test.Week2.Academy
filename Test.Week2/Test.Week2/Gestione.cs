using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Week2
{
    public class Gestione
    {
        public static List<Account> Accounts = new List<Account>()
        {
            new Account("A1007650091", Banca.Unicredit_Spa, 45067.80, new DateTime(2021/07/22))
        };
        public static bool Menu()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine();
            Console.WriteLine("1.   Crea un nuovo Account");
            Console.WriteLine("2.   Eseguire un movimento Bancario");
            Console.WriteLine("3.   Stampare i dati del conto ed i relativi movimenti bancari");
            Console.WriteLine("4.   Exit");
            int choice = InputVerification(4);
            Account a = new Account() { };
            return ChoiceManagment(choice, a);
        }
        public static bool ChoiceManagment(int choice, Account a)
        {
            bool cicle = true;
            switch (choice)
            {
                case 1:
                    a = NewAccount();
                    Accounts.Add(a);
                    break;
                case 2:
                    NewMovimento(a);
                    break;
                case 3:
                    Statement(a);
                    break;
                default:
                    cicle = false;
                    Console.WriteLine("GoodBye!");
                    break;
            }
            return cicle;
        }

        public static void Statement(Account a)
        {
            Console.WriteLine(a);
        }

        private static void NewMovimento(Account a)
        {
            Console.WriteLine("Scegli il tipo di operazione:");
            Console.WriteLine("1.   Pagamento");
            Console.WriteLine("2.   Accredito");
            int choice = InputVerification(2);
            if (choice == 1)
            {
                Console.WriteLine("Scegli il tipo di movimento:");
                Console.WriteLine("1.   Movimento Cash");
                Console.WriteLine("2.   Movimento Transfert");
                Console.WriteLine("3.   Movimento Credit Card");
                int choice2 = InputVerification(3);
                switch (choice2)
                {
                    case 1:
                        IMovimento mc = NewCash();
                        a.Movimenti.Add(mc);

                        break;
                    case 2:
                        IMovimento mt = NewTransfert();
                        a.Movimenti.Add(mt);

                        break;
                    case 3:
                        IMovimento mcc = NewCreditCard();
                        a.Movimenti.Add(mcc);

                        break;
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("Scegli il tipo di movimento:");
                Console.WriteLine("1.   Movimento Cash");
                Console.WriteLine("2.   Movimento Transfert");
                Console.WriteLine("3.   Movimento Credit Card");
                int choice2 = InputVerification(3);
                switch (choice2)
                {
                    case 1:
                        IMovimento mc = NewCash();
                        a.Movimenti.Add(mc);

                        break;
                    case 2:
                        IMovimento mt = NewTransfert();
                        a.Movimenti.Add(mt);

                        break;
                    case 3:
                        IMovimento mcc = NewCreditCard();
                        a.Movimenti.Add(mcc);

                        break;
                }
            }
        }

        public static MovimentoCash<IMovimento> NewCash()
        {
            MovimentoCash<IMovimento> mc = new MovimentoCash<IMovimento>();
            Console.WriteLine("Inserisci l'importo:");
            double importo = DVerification();
            mc.Importo = importo;

            return mc;
        }

        private static Account NewAccount()
        {
            string numeroConto = "A00567392870";
            Console.WriteLine("Saldo iniziale:");
            double saldo = DVerification();
            Console.WriteLine("Scegli il nome della tua banca:");
            Console.WriteLine("1.   Unicredit_Spa");
            Console.WriteLine("2.   Monte_dei_Paschi_di_Siena_Spa");
            Console.WriteLine("3.   Intesa_SanPaolo_Spa");
            Console.WriteLine("4.   Banco_Popolare");
            int choice = InputVerification(4);
            if(choice == 1)
            {
                Banca nomeBanca = Banca.Unicredit_Spa;
                Account a = new Account(numeroConto, nomeBanca, saldo, DateTime.Now);
                return a;
            }
            else if (choice == 2)
            {
                Banca nomeBanca = Banca.Monte_dei_Paschi_di_Siena_Spa;
                Account a = new Account(numeroConto, nomeBanca, saldo, DateTime.Now);
                return a;
            }
            else if (choice == 3)
            {
                Banca nomeBanca = Banca.Intesa_SanPaolo_Spa;
                Account a = new Account(numeroConto, nomeBanca, saldo, DateTime.Now);
                return a;
            }
            else if (choice == 4)
            {
                Banca nomeBanca = Banca.Banco_Popolare;
                Account a = new Account(numeroConto, nomeBanca, saldo, DateTime.Now);
                return a;
            }
            return null;
        }
        private static double DVerification()
        {
            bool verification = Double.TryParse(Console.ReadLine(), out double number);
            while (!verification || number < 0)
            {
                Console.WriteLine("Please, insert a correct value.");
                verification = Double.TryParse(Console.ReadLine(), out number);
            }
            return number;
        }

        public static int InputVerification(int maxChoice)
        {
            bool verification = Int32.TryParse(Console.ReadLine(), out int choice);
            while (choice > maxChoice || choice < 0 || verification == false)
            {
                Console.WriteLine("Please, insert a correct value.");
                verification = Int32.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }
    }
}
