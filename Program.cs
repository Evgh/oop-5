using System;

namespace oop_5
{

    interface IProduct
    {
        bool ToBuy()
        {
            Console.WriteLine("Товар куплен");
            return true;
        }

        bool ToSell()
        {
            Console.WriteLine("Товар продан");
            return true;
        }
    }

    abstract class Tech 
    {
        protected bool isRunning;
        public Tech()
        {
            isRunning = false;
        }

        public bool turnOn()
        {
            isRunning = true;
            return true;
        }

        public bool turnOff()
        {
            isRunning = false;
            return true;
        }

        public virtual bool isItRunning()
        {
            return isRunning;
        }
    }

    abstract class TypingTech : Tech
    {
        public abstract bool InputText();

    }

    sealed class Computer : TypingTech, IProduct
    {
        public override bool InputText()
        {
            Console.WriteLine("Набирается текст на клавиатуре");
            return true;
        } 
    }

    sealed class Tablet : TypingTech, IProduct 
    {
        public override bool InputText()
        {
            Console.WriteLine("Набирается текст на экранной клавиатуре");
            return true;
        }
    }

    sealed class Scaner : Tech, IProduct
    {

    }




    class Program
    {
        static void Main(string[] args)
        {
            Computer thing = new Computer();
            thing.turnOn();

            Console.WriteLine(thing.isItRunning());

        }
    }
}
