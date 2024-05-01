using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentStrategy
{
    public interface PaymentStrategy
    {
        void processPayment(double Amount);
    }
}
