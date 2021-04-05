using CleanCodeLabs.Codelab04.Workers;

namespace CleanCodeLabs.Codelab04
{
    public class FactoryApp
    {
        public static void Run()
        {
            var workers = new Worker[]
            {
                new Human("Joe"),
                new Horse("Jack"),
            };
            var automatedWorkers = new AutomatedWorker[] { new Robot("Robot") } ;

            var factoryHall = new FactoryHall(workers, automatedWorkers);
            factoryHall.StartWorking();
        }
    }
}