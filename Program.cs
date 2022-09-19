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
            Console.WriteLine("\tAdd Funds to shop balance - Press [4]");
            Console.WriteLine("\tExit Application - Press [e]\n");
            Console.WriteLine("###########################################################################\n");
            Console.WriteLine("Enter your choice down below");

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
                case "e":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\tError, Invaild Option, Try Aagin");
                    ShopFront();
                    break;
            }

           
        }

        public static void CatOne()
        {
            Console.WriteLine("\tPress any button to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********Category One - Products*********");
            Console.WriteLine("\tProduct 1 ($10) - Press [1] to purchase");
            Console.WriteLine("\tProduct 2 ($5) - Press [2] to purchase");
            Console.WriteLine("\tProduct 3 ($5) - Press [3] to purchase");
            Console.WriteLine("\tProduct 4 ($10) - Press [4] to purchase");
            Console.WriteLine("\tReturn to Shop Front - Press [5]\n");
            Console.WriteLine("\tEnter your choice down below");
            switch(Console.ReadLine())
            {
                case "1":
                    money -= 10;
                    Console.WriteLine($"\tThank you for your purchase! Product 1 purchased, funds updated ${money}");
                    CatOne();
                    break;
                case "2":
                    money -= 5;
                    Console.WriteLine($"\tThank you for your purchase! Product 2 purchased, funds updated ${money}");
                    CatOne();
                    break;
                case "3":
                    money -= 5;
                    Console.WriteLine($"\tThank you for your purchase! Product 3 purchased, funds updated ${money}");
                    CatOne();
                    break;
                case "4":
                    money -= 10;
                    Console.WriteLine($"\tThank you for your purchase! Product 4 purchased, funds updated ${money}");
                    CatOne();
                    break;
                case "5":
                    ShopFront();
                    break;
                default:
                    Console.WriteLine("\tError, Invaild Option, Try Aagin");
                    CatOne();
                    break;
            }
        }
        public static void CatTwo()
        {
            Console.Clear();
            Console.WriteLine("Category Two");
        }
        public static void CatThree()
        {
            Console.Clear();
            Console.WriteLine("Category Three");
        }

        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\tShop Funds are now: {money}");   
        }

        static void Main(string[] args)
        {
            ShopFront();
            Console.ReadKey();
        }
    }
}
