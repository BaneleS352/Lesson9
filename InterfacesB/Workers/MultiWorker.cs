using InterfacesB.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesB.Workers
{
    // TODO: Implement both interfaces EXPLICITLY
    public class MultiWorker : IWorkerA, IWorkerB
    {
        // TODO: explicit IWorkerA.DoWork prints "A working"
        void IWorkerA.DoWork()
        {
            Console.WriteLine("A working");
        }
        // TODO: explicit IWorkerB.DoWork prints "B working"
        void IWorkerB.DoWork()
        {
            Console.WriteLine("B working");
        }
    }
}
