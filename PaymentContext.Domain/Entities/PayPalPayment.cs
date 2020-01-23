    using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transactionCode, DateTime paidDate, DateTime expiredDate, decimal total, decimal totalPaid, string owner, string documento, string address, string email) 
        : base(paidDate, expiredDate, total, totalPaid, owner, documento, address, email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }   
    }
}