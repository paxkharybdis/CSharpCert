using System;

namespace Week1.Fundamentals
{
    public class dinosaur
    {
            private string _teeth;  // field
            //private string _something;
            private int _size;

            public string Color { protected set; get; }  = "Green"; // Property with default property

            public int Size
            {
                set
                {
                    this._size = value;
                }
                get
                {
                    if(_size > 200)
                    {
                        Console.WriteLine("You're huge");
                    }
                    return _size;
                }
            }

            public bool Skin { set; get; }

            public string Teeth 
            {
                 set
                 {
                     this._teeth = value;
                 }
                 get
                 {
                     return _teeth;
                 }
            }

            public virtual void Eat()
            {
                Console.WriteLine("Eat");
            }

            public class Raptor : dinosaur // Inner class
            {
                public void Group()
                {
                    Color = "Brown";
                }
            }
    }

    public class TRex : dinosaur
    {
        public void Stomp()
        {
            Color = "Blue";
        }

        public override void Eat()
        {
            Console.WriteLine("Rip");
        }
    }
}
