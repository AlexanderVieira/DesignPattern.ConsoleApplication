using AVS.DesignPatterns.Structural.Facade.Domain;
using System;
using System.Linq;

namespace AVS.DesignPatterns.Behavioral.Strategy
{
    public class PaymentTransferService : IPayment
    {
        private readonly IPaymentTransferFacade _paymentTransferFacade;

        public PaymentTransferService(IPaymentTransferFacade paymentTransferFacade)
        {
            _paymentTransferFacade = paymentTransferFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting Payment Transfer - Value $ " + payment.Value);

            payment.TransferConfirmation = _paymentTransferFacade.PerformTransfer();
            payment.Status = "Paid Transfer";
            return payment;
        }
    }
}
