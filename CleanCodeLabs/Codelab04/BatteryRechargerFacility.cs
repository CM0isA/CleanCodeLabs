using System;
using CleanCodeLabs.Codelab04.Workers;
using CleanCodeLabs.Codelab04;

namespace CleanCodeLabs.Codelab04
{
    internal class BatteryRechargerFacility
    {
        public static void RechargeBatteriesOf(AutomatedWorker[] rechargers)
        {
            foreach (var recharger in rechargers)
            {
                Console.WriteLine(recharger.RechargeBatteries());
            }
        }
    }
}