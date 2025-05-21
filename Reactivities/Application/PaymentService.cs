using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class PaymentService : IPaymentService
    {
        private readonly IEnumerable<IPaymentProcessor> _paymentProcessor; 
        public PaymentService(IEnumerable<IPaymentProcessor> paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void ProcessPayment(string paymentType)
        {
            foreach( var item in _paymentProcessor)
            {
                if (item is PaymentChecker)
                {
                    item.ProcessPayment(paymentType);
                   Console.WriteLine("Payment was successful.");
                    
                }
                if (item is PaymentProcessor)
                {
                    item.ProcessPayment(paymentType);
                    Console.WriteLine("Payment was successful.");
                }
            }
            
        }
    }
}
