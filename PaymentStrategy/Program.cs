using System;

namespace PaymentStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor p1 = new PaymentProcessor(new CreditCardPaymentStrategy());

            p1.processPayment(1000);

            PaymentProcessor p2 = new PaymentProcessor(new PaypalCardPaymentStrategy());

            p2.processPayment(3000);

            PaymentProcessor p3 = new PaymentProcessor(new QrCodePaymentStrategy());

            p3.processPayment(3500);

            Console.WriteLine("Hello World!");
        }
    }
}
