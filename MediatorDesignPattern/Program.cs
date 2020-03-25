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

            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"");
            Console.WriteLine("\tTest1: Helicopter requesting takeoff");
            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\n");

            Choppa.RequestTakeoff();

            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"");
            Console.WriteLine("\tTest2: Helicopter requesting landing");
            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\n");

            Choppa.RequestLanding();


            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"");
            Console.WriteLine("\tTest3: Airplane requesting takeoff");
            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\n");

            plane.RequestTakeoff();

            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"");
            Console.WriteLine("\tTest3: Airplane requesting landing");
            Console.WriteLine("\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\n");


            plane.RequestLanding();



        }
    }
}
