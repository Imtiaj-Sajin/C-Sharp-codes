using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    public class CarSpeed
    {
       public float acceleration;
       public string engine_number;
       public bool start;
       public float time;

       public CarSpeed()
        {
            this.acceleration = 0;
            this.engine_number = "";
            this.start = false;
            this.time = 0;
        }

       public bool StartCar()
        {
            Console.Out.WriteLine("Car Started");
            return true;
        }
       public bool StopCar()
        {
            Console.Out.WriteLine("Car Stopped");
            return true;
        }

        void SetAcceleration(float acc)
        {
            this.acceleration = acc;
        }
        void Engine_Number(string e_num)
        {
            this.engine_number = e_num;
        }
        void SetTime(float t)
        {
            this.time = t;
        }
        public float Get_Velocity()
        {
            if (StartCar()==true)
            {
                return time * acceleration;
            }
            else
            {
                Console.Out.WriteLine("Start The car first");
                return 0;
            }

        }



    }
    class Program
    {
        static void Main(string[] args)
        {

            int n = 3;
            CarSpeed[] car=new CarSpeed[n];
            for (int i = 0; i < n; i++)
            {
                car[i] = new CarSpeed();
                Console.Out.WriteLine("\nDetails for the car"+(i+1));
                Console.Out.Write("Enter the engine number:");
                car[i].engine_number = Console.ReadLine();

                Console.Out.Write("Enter the acceleration:");
                car[i].acceleration = float.Parse(Console.ReadLine());

                Console.Out.Write("Enter the time:");
                car[i].time = float.Parse(Console.ReadLine());

                Console.Out.WriteLine("Eingine number of a car set to " + car[i].engine_number);
                Console.Out.WriteLine("Car's acceleration is " + car[i].acceleration);

                Console.Out.WriteLine("Velocity of the car after " + car[i].time + " is " + car[i].Get_Velocity());
                car[i].StopCar();
            }



        }
    }
}
