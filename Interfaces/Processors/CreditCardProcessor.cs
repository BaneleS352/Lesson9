using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"[Credit Card] Payment processed for {amount:C}");
        }
    }


}
