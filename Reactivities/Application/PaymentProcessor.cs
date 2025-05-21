using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IPaymentProcessor
    { 
    void ProcessPayment(string paymentType);
    void PaymentSuccess();
    }
    public  class PaymentProcessor:IPaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CC")
            { 
                Console.WriteLine("Processing credit card payment...");
            }
            else if (paymentType == "PP")
            {
                Console.WriteLine("Processing PayPal payment...");
            }
            else
            {
                Console.WriteLine("Invalid payment type.");
            }  
        }
        public void PaymentSuccess()
        {
            Console.WriteLine("Payment was successful.");
        }   
    }
    public class PaymentChecker : IPaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CC")
            {
                Console.WriteLine("your are eligible");
            }
            else if (paymentType == "PP")
            {
                Console.WriteLine("you are not eligible");
            }
            else
            {
                Console.WriteLine("Invalid payment type.");
            }
        }
        public void PaymentSuccess()
        {
            Console.WriteLine("Payment was successful.");
        }
    }
}
