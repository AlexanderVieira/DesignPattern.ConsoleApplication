using System;
using System.Linq;

namespace AVS.DesignPatterns.Behavioral.Strategy
{
    public class PaymentSlitFacade : IPaymentBilletFacade
    {
        public string GenerateBillet()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                              .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
