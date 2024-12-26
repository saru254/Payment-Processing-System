/* Payment Processing System
 * create a pyament base class with a method MakePayment()
 * derive classes like CreditCardPayment and PayPalPayment
 * override MakePayment() in each subclass to provide specific payment logic
 * Write a program to process payments of different types using Polymorphism. */

using System;

namespace PaymentProcessingSystem
{
    //base class
    class Payment
    {
        //virtual method to be overridden by derived classes
        public virtual void MakePayment()
        {
            Console.WriteLine("Processing a generic payment....");
        }
    }

    //derived class:CreditCardPayment
    class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }

        //constructor
        public CreditCardPayment(string cardNumber, string cardHolderName)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
        }

        // override makepayment method
        public override void MakePayment()
        {
            Console.WriteLine($"Processing payment using Credit Card...");
            Console.WriteLine($"Card Holder: {CardHolderName}");
            Console.WriteLine($"Card Number: {CardNumber.Substring(0,4)}");
        }
    }

    // derived class: paypalpayment
    class PayPalPayment : Payment
    { 
        public string Email { get; set; }

        //constructor
        public PayPalPayment(string email)
        {
            Email = email;
        }

        // override makepayment method
        public override void MakePayment()
        {
            Console.WriteLine($"Processing payment using Paypal....");
            Console.WriteLine($"Paypal Account: {Email}");
        }
    }

    //main program
    class program
    {
        static void Main(string[] args)
        {
            //array of different payment types
            Payment[] payments = new Payment[]
            {
                new CreditCardPayment("123456789123456", "Mchawia"),
                new PayPalPayment("Mchawia@gmail.com")
            };

            //process each payment using polymorphism
            foreach (Payment payment in payments)
            {
                payment.MakePayment();
                Console.WriteLine();
            }

        }
    }


}