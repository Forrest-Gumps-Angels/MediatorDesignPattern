using System;

namespace MediatorDesignPattern2
{
    public interface IMediator
    {
        void Notify(object sender, string msg);
    }

    public class Mediator : IMediator
    {
        public Mediator()
        {

        }

        public void Notify(object sender, string msg)
        {

        }
    }

    public class BaseComponent 
    {
        public BaseComponent(IMediator m)
        {
            _mediator = m;
        }

        protected IMediator _mediator;
    }

    public class ComponentA : BaseComponent
    {
        public void DoSomething()
        {
            Console.WriteLine("ComponentA did something");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
