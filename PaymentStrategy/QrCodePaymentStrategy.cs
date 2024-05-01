using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategy
{
    public class QrCodePaymentStrategy : PaymentStrategy
    {
        public void processPayment(double amount)
        {
            Console.WriteLine("Processing qr code payment of amount : " + amount);
        }
    }
}
