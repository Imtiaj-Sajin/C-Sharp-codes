using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Math;

namespace Lab1
{
    class Calculator{
        public float x,y;

        public void Add() {
            Console.Write("Number1 :");
            this.x=Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2 :");
            this.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans: (" + x + "+" + y + ")=" + (x + y));
        }

        public void Sub()
        {
            Console.Write("Number1 :");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2 :");
            this.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans: (" +x+"-"+y+")="+ (x - y));
        }

        public void Mul()
        {
            Console.Write("Number1 :");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2 :");
            this.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans: (" + x + "*" + y + ")=" + (x * y));
        }

        public void Div()
        {
            Console.Write("Number1 :");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number2 :");
            this.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans: (" + x + "/" + y + ")=" + (x / y));
        }

        public void Pow()
        {
            Console.Write("Number :");
            this.x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Power :");
            this.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ans: (" + x + " to the power of " + y + ")=" + Math.Pow(x,y));
        }

        public void Sqrt()
        {
            Console.Write("Number :");
            this.x = Convert.ToInt32(Console.ReadLine());
             
            Console.WriteLine("Ans: (Squre root of "+ x + ")=" + Math.Sqrt(x));
        }
        
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Calculator obj = new Calculator();
            
            do
            {
                Console.WriteLine("\nWhich option you wanna use:\n 1)Add\n 2)Substaction\n 3)Multiplication\n 4)Division\n 5)Squre Root\n 6)Power");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        obj.Add();
                        break;
                    case 2:
                        obj.Sub();
                        break;
                    case 3:
                        obj.Mul();
                        break;
                    case 4:
                        obj.Div();
                        break;
                    case 5:
                        obj.Sqrt();
                        break;
                    case 6:
                        obj.Pow();
                        break;
                    default:
                        Console.WriteLine("Use proper option");
                        break;


                }
            } while (option != 0);

        }
    }
}
