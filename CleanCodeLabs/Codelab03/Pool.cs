using CleanCodeLabs.Codelab03.Ducks;
using System;

namespace CleanCodeLabs.Codelab03
{
    public class Pool
    {
        public void OpenForBusiness(params IDuck[] ducks)
        {
            Quack(ducks);
            Swim(ducks);
        }

        private void Quack(IDuck[] ducks)
        {
            foreach (var duck in ducks)
            {
                duck.Quack();
            }
        }

        private void Swim(IDuck[] ducks)
        {
            foreach (var duck in ducks)
            {
                if (duck.GetType() != typeof(ElectronicDuck))
                {
                    duck.Swim();
                }
            }
        }
    }
}