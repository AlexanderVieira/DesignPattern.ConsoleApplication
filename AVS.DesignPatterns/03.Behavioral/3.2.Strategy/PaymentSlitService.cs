using AVS.DesignPatterns.Structural.Facade.Domain;
using System;
using System.Linq;

namespace AVS.DesignPatterns.Behavioral.Strategy
{
    public class PaymentBilletService : IPayment
    {
        private readonly IPaymentBilletFacade _paymentBilletFacade;

        public PaymentBilletService(IPaymentBilletFacade paymentSlipFacade)
        {
            _paymentBilletFacade = paymentSlipFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting Payment Billet - Amount $ " + payment.Value);

            payment.DigitableLine = _paymentBilletFacade.GenerateBillet();
            payment.Status = "Awaiting payment";
            return payment;
        }
    }
}
