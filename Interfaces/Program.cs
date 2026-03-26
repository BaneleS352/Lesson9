using Interfaces.Interfaces;
using Interfaces.Processors;
using Interfaces.Services;

// TODO:
// 1) Create a CheckoutService using CreditCardProcessor and call Checkout(1200m)
var creditCardService = new CheckoutService(new CreditCardProcessor());
creditCardService.Checkout(1200m);
// 2) Create a CheckoutService using PayPalProcessor and call Checkout(1200m)
// 3) Confirm CheckoutService did not change
var paypalService = new CheckoutService(new PayPalProcessor());
paypalService.Checkout(1200m);

var bankService = new CheckoutService(new BankTransferProcessor());
bankService.Checkout(350m);
