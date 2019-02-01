using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleToneDemo
{
    abstract class Mediator

    {
        public abstract void Send(string message,
          Colleague colleague);
    }

    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>

    class ConcreteMediator : Mediator

    {
        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public ConcreteColleague1 Colleague1
        {
            set { _colleague1 = value; }
        }

        public ConcreteColleague2 Colleague2
        {
            set { _colleague2 = value; }
        }

        public override void Send(string message,
          Colleague colleague)
        {
            if (colleague == _colleague1)
            {
                _colleague2.Notify(message);
            }
            else

            {
                _colleague1.Notify(message);
            }
        }
    }

    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    abstract class Colleague

    {

        // Constructor

        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        protected Mediator Mediator { get; set; }
    }

    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class ConcreteColleague1 : Colleague

    {
        // Constructor

        public ConcreteColleague1(Mediator mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague1 gets message: "

              + message);
        }
    }

    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class ConcreteColleague2 : Colleague

    {
        // Constructor

        public ConcreteColleague2(Mediator mediator)
          : base(mediator)
        {
        }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: "

              + message);
        }
    }
}
