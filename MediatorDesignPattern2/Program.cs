// ------------------------------------------------------------------------------------- //
// Partly borrowed from https://refactoring.guru/design-patterns/mediator/csharp/example //
// ------------------------------------------------------------------------------------- //

using System;

namespace MediatorDesignPattern2
{
    public interface IMediator
    {
        void Notify(object sender, string msg);
    }

    public class Mediator : IMediator
    {
        public Mediator(ComponentA compA, ComponentB compB, ComponentC compC)
        {
            _componentA = compA;
            _componentB = compB;
            _componentC = compC;
            _componentA.SetMediator(this);
            _componentB.SetMediator(this);
            _componentC.SetMediator(this);
        }

        public void Notify(object sender, string msg)
        {
            if(msg == "A")
            {
                Console.WriteLine("Mediator receives A from componentA and calls ComponentB.DoSomething()");
                _componentB.DoSomething();
            }

            if (msg == "B")
            {
                Console.WriteLine("Mediator receives B from componentB and calls ComponentC.DoSomething()");
                _componentC.DoSomething();
            }

            if (msg == "C")
            {
                Console.WriteLine("Mediator receives C and does nothing");
            }
        }

        private ComponentA _componentA;
        private ComponentB _componentB;
        private ComponentC _componentC;
    }

    public class BaseComponent 
    {
        public BaseComponent(IMediator m = null)
        {
            _mediator = m;
        }

        public void SetMediator(IMediator m)
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
            this._mediator.Notify(this, "A");
        }
    }

    public class ComponentB : BaseComponent
    {
        public void DoSomething()
        {
            Console.WriteLine("ComponentB did something");
            this._mediator.Notify(this, "B");
        }
    }

    public class ComponentC : BaseComponent
    {
        public void DoSomething()
        {
            Console.WriteLine("ComponentC did something");
            this._mediator.Notify(this, "C");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ComponentA componentA = new ComponentA();
            ComponentB componentB = new ComponentB();
            ComponentC componentC = new ComponentC();
            new Mediator(componentA, componentB, componentC);

            Console.WriteLine("Starting off by calling ComponentA.DoSomething() \n");
            componentA.DoSomething();
        }
    }
}
