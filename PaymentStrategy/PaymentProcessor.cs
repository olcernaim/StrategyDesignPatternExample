using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategy
{
    public class PaymentProcessor
    {
        private PaymentStrategy _paymentStrategy;

        public PaymentProcessor(PaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void processPayment(double amount)
        {
            _paymentStrategy.processPayment(amount);
        }
    }
}
