using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Processors
{
    public class PayPalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[PayPal] Payment processed for {amount:C}");
        }
    }
}
