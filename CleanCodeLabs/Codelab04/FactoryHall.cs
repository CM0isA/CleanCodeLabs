using System;
using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryHall
    {
        private readonly Worker[] _workers;
        private readonly AutomatedWorker[] _automatedWorkers;

        public FactoryHall(Worker[] workers, AutomatedWorker[] automatedWorkers)
        {
            _workers = workers;
            _automatedWorkers = automatedWorkers;
        }

        public void StartWorking()
        {
            // WORK
            foreach (var worker in _workers)
            {
                Console.WriteLine(worker.Work());
            }
            foreach (var robot in _automatedWorkers)
            {
                Console.WriteLine(robot.Work());
            }

            // EAT
            new Lunchroom(_workers).StartLunching();

            // RECHARGE BATTERIES
            BatteryRechargerFacility.RechargeBatteriesOf(_automatedWorkers);
        }
    }
}