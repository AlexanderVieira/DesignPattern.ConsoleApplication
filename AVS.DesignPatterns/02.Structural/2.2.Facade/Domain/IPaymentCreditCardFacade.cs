namespace AVS.DesignPatterns.Structural.Facade.Domain
{
    public interface IPaymentCreditCardFacade
    {
        bool PerformPayment(Order order, Payment payment);
    }
}
