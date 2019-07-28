using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternDuck
{
    /// <summary>
    /// Quack Behaviour
    /// </summary>
    public interface IQuackBehaviour
    {
        void quack();
    }
    class simpleQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I Simple Quack");
        }
    }
    class noQuack:IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I no Quack");
        }
    }
    /// <summary>
    /// Fly Behaviour
    /// </summary>
    public interface IFly
    {
        void fly();
    } 
    public class highFly:IFly
    {
        public void fly()
        {
            Console.WriteLine("I Fly high");
        }
    }
    class lowFly : IFly
    {
        public void fly()
        {
            Console.WriteLine("I Fly low");
        }
    }
    /// <summary>
    /// Duck
    /// </summary>
    class duck
    {
        private IQuackBehaviour quackBehaviour;
        private IFly flyBehaviour;

        public duck(IQuackBehaviour quack,IFly fly)
        {
            this.quackBehaviour = quack;
            this.flyBehaviour = fly;
        }
        public void quackMethod()
        {
            quackBehaviour.quack();
        }
        public void flyMethod()
        {
            flyBehaviour.fly();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            duck d1 = new duck(new noQuack(),new highFly());
            d1.quackMethod();
            d1.flyMethod();

            Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
