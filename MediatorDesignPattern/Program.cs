using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower MainControlTower = new ControlTower();
            Helicopter Choppa = new Helicopter(MainControlTower);
            Airplane plane = new Airplane(MainControlTower);

            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("Test 1: Helicopter requesting takeoff");
            Console.WriteLine("------------------------------------------------------------------");

            Choppa.RequestTakeoff();

            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("Test 2: Helicopter requesting landing");
            Console.WriteLine("------------------------------------------------------------------");

            Choppa.RequestLanding();


            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("Test 3: Airplane requesting takeoff");
            Console.WriteLine("------------------------------------------------------------------");

            plane.RequestTakeoff();

            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("Test 4: Airplane requesting landing");
            Console.WriteLine("------------------------------------------------------------------");


            plane.RequestLanding();



        }
    }
}
