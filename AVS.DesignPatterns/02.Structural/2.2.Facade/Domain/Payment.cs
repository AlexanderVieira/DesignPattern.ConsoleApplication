namespace AVS.DesignPatterns.Structural.Facade.Domain
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Value { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        // Possiveis meios de pagamento implementados direto 
        // na classe pagamento por brevidade do exemplo
        public string CreditCard { get; set; }
        public string DigitableLine { get; set; }
        public string TransferConfirmation { get; set; }
    }
}