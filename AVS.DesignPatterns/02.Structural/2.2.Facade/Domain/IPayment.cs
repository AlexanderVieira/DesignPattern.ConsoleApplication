namespace AVS.DesignPatterns.Structural.Facade.Domain
{
    public interface IPayment
    {
        Payment PerformPayment(Order order, Payment payment);
    }
}
