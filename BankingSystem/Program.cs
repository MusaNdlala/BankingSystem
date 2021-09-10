using System;

namespace BankingSystem
{
    class Program
    {
        static double balance = 1000;
        static void Main(string[] args)
        {
            
            char c;
            do
            {
                Console.WriteLine("e for exit, d for deposit, w for with withdraw, b for balance");
                c = Convert.ToChar(Console.ReadLine());
                bye(c);
                if (c == 'b' || c == 'b')
                {
                    Console.WriteLine(balance);
                    Console.WriteLine("e for exit, d for deposit, w for with withdraw, b for balance");
                    c = Convert.ToChar(Console.ReadLine());
                    bye(c);
                }
                Console.WriteLine("please the amount");
                double amount = Convert.ToDouble(Console.ReadLine());
                balance = BankingSystem(c, amount);//balance;                
            } while (c != 'e' || c != 'E');           
            Console.Read();
        }
        private static double BankingSystem(char action, double amount){
            double Dresult = balance;
            switch (action)
                {
                    case 'd':case 'D':
                        Dresult = Deposit(amount,balance);
                        break;
                    case 'w':case 'W':
                    Dresult = withDrawal(amount, balance);
                        break;
                    case 'b':case 'B':
                        Console.WriteLine(Dresult);
                        break;
                    default:
                        Console.WriteLine("invalid data");
                        break;
                }           
            return Dresult;
        }
        private static double Deposit(double amount, double balance){
            return balance + amount;
        }
        private static double withDrawal(double amount, double balance)
        {
            if (amount > balance)
            {
                Console.WriteLine("insufficaint funds");
                return balance;
            }
            return balance - amount;
        }
        private static void bye(char c)
        {
            if (c == 'e' || c == 'E')
            {
                Environment.Exit(0);
            }
        }
    }
}
