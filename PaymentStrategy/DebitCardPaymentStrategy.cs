using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategy
{
    public class DebitCardPaymentStrategy : PaymentStrategy
    {
        public void processPayment(double amount)
        {
            Console.WriteLine("Processing debit card payment of amount : " + amount);
        }
    }
}
