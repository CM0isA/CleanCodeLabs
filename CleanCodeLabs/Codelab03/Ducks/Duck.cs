using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class Duck : IDuck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack...");
        }

        public virtual void Swim()
        {
            Console.WriteLine("Swim...");
        }
    }
}