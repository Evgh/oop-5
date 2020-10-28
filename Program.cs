using System;

namespace oop_5
{

    interface IProduct
    { 
        void ToBuy()
        {
            Console.WriteLine("Товар куплен.");
        }

        void ToSell()
        {
            Console.WriteLine("Товар продан.");
        }

        void DoThing()
        {
            Console.WriteLine("Товар делает штуку по-интерфейсовски.");
        }
    }

    abstract class Tech 
    {
        protected bool isRunning;
        protected Tech()
        {
            isRunning = false;
        }

        public bool TurnOn()
        {
            isRunning = true;
            return true;
        }

        public bool TurnOff()
        {
            isRunning = false;
            return true;
        }

        public virtual bool IsItRunning()
        {
            return isRunning;
        }
    }

    abstract class TypingTech : Tech
    {
        public abstract bool InputText();
    }


    sealed class Scaner : Tech, IProduct
    {   
        public override bool IsItRunning()
        {
            if (base.isRunning)
            {
                Console.WriteLine("Сканер сканирует.");
            }
            else
            {
                Console.WriteLine("Сканер не сканирует.");
            }
            return base.isRunning;
        }

        // Штуки.
        public void DoThing()
        {
            Console.WriteLine("Сканер делает штуку по-сканерски");
        }
        void IProduct.DoThing()
        {
            Console.WriteLine("Сканер делает штуку по-интерфейсовски");
        }
    }


    sealed class Computer : TypingTech, IProduct
    {
        public override bool IsItRunning()
        {
            if (base.isRunning)
            {
                Console.WriteLine("Компьютер компьютерирует");
            }
            else
            {
                Console.WriteLine("Компьютер не компьютерирует");
            }
            return base.isRunning;
        }
        public override bool InputText()
        {
            Console.WriteLine("Набирается текст на клавиатуре");
            return true;
        }




        // Штуки.
        public void DoThing()
        {
            Console.WriteLine("Компьютер делает штуку по-компьютерски");
        }
        void IProduct.DoThing()
        {
            Console.WriteLine("Компьютер делает штуку по-интерфейсовски");
        }
    }

    sealed class Tablet : TypingTech, IProduct 
    {
        public override bool IsItRunning()
        {
            if (base.isRunning)
            {
                Console.WriteLine("Планшет планшетирует");
            }
            else
            {
                Console.WriteLine("Планшет не планшетирует");
            }
            return base.isRunning;
        }


        public override bool InputText()
        {
            Console.WriteLine("Набирается текст пальцами");
            return true;
        }

        // Штуки.
        public void DoThing()
        {
            Console.WriteLine("Планшет делает штуку по-планшетски");
        }
        void IProduct.DoThing()
        {
            Console.WriteLine("Планшет делает штуку по-интерфейсовски");
        }

        // Переопределение методов обджекта.
        public override int GetHashCode()
        {
            Random rr = new Random();
            return rr.Next();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"Сканер{GetHashCode()}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Computer thing = new Computer();
            thing.TurnOn();

            thing.DoThing();
            ((IProduct)thing).DoThing();

            Console.WriteLine(thing.IsItRunning());

        }
    }
}
