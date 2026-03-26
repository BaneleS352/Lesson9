using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Services
{
    public class CheckoutService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public CheckoutService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void Checkout(decimal total)
        {
            if (total <= 0)
            {
                Console.WriteLine("Checkout failed: total must be greater than 0.");
                return;
            }

            Console.WriteLine($"Checkout started. Total: {total:C}");
            _paymentProcessor.ProcessPayment(total);
            Console.WriteLine("Checkout complete.");
        }
    }
}
