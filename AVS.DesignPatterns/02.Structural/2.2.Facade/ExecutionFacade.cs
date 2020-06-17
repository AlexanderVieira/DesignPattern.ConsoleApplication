using AVS.DesignPatterns.Structural.Facade.CrossCutting;
using AVS.DesignPatterns.Structural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AVS.DesignPatterns._02.Structural._2._2.Facade
{
    public class ExecutionFacade
    {
        public static void Run()
        {
            var products = new List<Product>
            {
                new Product{Name = "Sneakers", Value = new Random().Next(299)},
                new Product{Name = "Shirt", Value = new Random().Next(299)},
                new Product{Name = "Tennis Racket", Value = new Random().Next(299)}
            };

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var payment = new Payment
            {
                CreditCard = "5555 2222 4444 8888"
            };

            var paymentService = new PaymentCreditCardService(new PaymentCreditCardFacade(new PayPalGateway(), new ConfigurationManager()));

            var paymentResult = paymentService.PerformPayment(order, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }
}
