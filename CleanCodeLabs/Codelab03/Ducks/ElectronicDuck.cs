using System;

namespace CleanCodeLabs.Codelab03.Ducks
{
    public class ElectronicDuck : IElectronicDuck
    {
        private bool _isSwitchedOn;

        public void Quack()
        {
            if (!_isSwitchedOn)
            {
                TurnOn();
            }

            Console.WriteLine("Quack Quack... (in a robot voice)");
        }

        public void Swim()
        {
            throw new NotImplementedException("Eletronic ducks can't swim, they'll break in water!");
        }

        public void TurnOn()
        {
            _isSwitchedOn = true;
        }

        public void TurnOff()
        {
            _isSwitchedOn = false;
        }
    }
}