using System;
using System.Collections.Generic;
using Flunt.Validations;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
    public class Subscription : Entity
    {
        private IList<Payment> _payments;
        public Subscription(DateTime? expireDate)
        {
            CreateDate = DateTime.Now;
            LastUpdatetDate = DateTime.Now;
            ExpireDate = expireDate;
            Active = true;
            _payments = new List<Payment>();
        }

        public DateTime CreateDate { get; private set; }
        public DateTime LastUpdatetDate { get; private set; }
        public DateTime? ExpireDate { get; private set; }
        public bool Active { get; private set; }
        public IReadOnlyCollection<Payment> Payments { get; set; }

        public void AddPayment(Payment payment)
        {
            AddNotifications(new Contract()
                .Requires()
                .IsGreaterThan(DateTime.Now, payment.PaidDate, "Subscription.Payments", "A data do pagamento deve ser futura.")
            );
            //if(Valid) Só adiciona se for válido
            _payments.Add(payment);
        }

        public void Activate()
        {
            Active = true;
            LastUpdatetDate = DateTime.Now;
        }

        public void Inactivate()
        {
            Active = false;
            LastUpdatetDate = DateTime.Now;
        }

    }
}