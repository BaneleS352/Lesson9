using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Processors
{
    public class BankTransferProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[Bank Transfer] Payment processed for {amount:C}");
        }
    }
}
