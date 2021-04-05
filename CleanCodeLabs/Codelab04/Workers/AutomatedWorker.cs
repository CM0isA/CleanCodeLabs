namespace CleanCodeLabs.Codelab04.Workers
{
    public abstract class AutomatedWorker
    {
        protected AutomatedWorker(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract string Work();

        public abstract string RechargeBatteries();
    }
}