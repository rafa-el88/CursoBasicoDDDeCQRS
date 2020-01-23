using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditPayment : Payment
    {
        public CreditPayment(string cardHolderName, string cardNumber, string lastTransactionNumber, DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string owner, string documento, string address, string email)
        : base(paidDate, expiredDate, total, totalPaid, owner, documento, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}