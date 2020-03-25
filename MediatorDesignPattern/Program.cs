using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlTower MainControlTower = new ControlTower();
            Helicopter Choppa = new Helicopter(MainControlTower);

            Choppa.RequestLanding();



            Console.WriteLine("Hello World!");
        }
    }
}
