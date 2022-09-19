using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
        //global variable
        public static int money = 100;

        public static void ShopFront()
        {
            Console.WriteLine("###########################################################################");
            Console.WriteLine($"\tYour current balance: {money}");
            Console.WriteLine("\tShop Category 1 - Press [1]");
            Console.WriteLine("\tShop Category 2 - Press [2]");
            Console.WriteLine("\tShop Category 3 - Press [3]");
            Console.WriteLine("\tAdd Funds to shop balance - Press [4]\n");
            Console.WriteLine("###########################################################################\n");
            Console.WriteLine("\tEnter your choice down below");
            switch(Console.ReadLine())
            {
                case "1": 
                    CatOne();
                    break;
                case "2":
                    CatTwo();
                    break;
                case "3":
                    CatThree();
                    break;
                case "4":
                    AddFunds();
                    break;
                default:
                    Console.WriteLine("\tError, Invaild Option, Try Aagin");
                    ShopFront();
                    break;
            }

           
        }

        public static void CatOne()
        {
            Console.WriteLine("Category One");
        }
        public static void CatTwo()
        {
            Console.WriteLine("Category Two");
        }
        public static void CatThree()
        {
            Console.WriteLine("Category Three");
        }

        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds");
        }

        static void Main(string[] args)
        {
            ShopFront();
            Console.ReadKey();
        }
    }
}
