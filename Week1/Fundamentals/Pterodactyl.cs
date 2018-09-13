using System;

namespace Week1.Fundamentals
{
    public class Pterodactyl : dinosaur
    {
        public override void Eat()
        {
            Console.WriteLine("Pterodactyl Eat");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }



    }
}