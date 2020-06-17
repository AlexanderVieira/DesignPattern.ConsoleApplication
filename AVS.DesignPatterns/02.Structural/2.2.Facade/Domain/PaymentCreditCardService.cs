using System;
using System.Linq;

namespace AVS.DesignPatterns.Structural.Facade.Domain
{
    public class PaymentCreditCardService : IPayment
    {
        private readonly IPaymentCreditCardFacade _paymentCreditCardFacade;

        public PaymentCreditCardService(IPaymentCreditCardFacade paymentCreditCardFacade)
        {
            _paymentCreditCardFacade = paymentCreditCardFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Iniciando pagamento via cartão de crédito.");

            if (_paymentCreditCardFacade.PerformPayment(order, payment))
            {
                payment.Status = "Pago via Cartão de crédito";
                return payment;
            }

            payment.Status = "Cartão de crédito recusado.";
            return payment;
        }
    }
}
