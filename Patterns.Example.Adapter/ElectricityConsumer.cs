using System;
using System.Management;
using Patterns.Example.Adapter.Models;

namespace Patterns.Example.Adapter
{
    class ElectricityConsumer
    {
        public static void ChargeNoteBook(INewElectricitySystem electricitySystem)
        {
            Console.WriteLine(electricitySystem.MatchWideSocet());
        }
    }
}
