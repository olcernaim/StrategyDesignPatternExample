using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategy
{
    public class PaypalCardPaymentStrategy : PaymentStrategy
    {
        public void processPayment(double amount)
        {
            Console.WriteLine("Processing paypal payment of amount : " + amount);
        }
    }
}
