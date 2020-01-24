using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        private readonly Name _name;
        private readonly Email _email;
        private readonly Document _document;
        private readonly Address _address;
        private readonly Student _student;
        private readonly Subscription _subscription;

        // [TestMethod]
        // public void ShouldReturnErrorWhenActiveHadSubscription()
        // {
        //     var name = new Name("Rafael", "Rodrigues");
        //     var document = new Document("06606053927", EDocumentType.CPF);
        //     var email = new Email("rafaa.cfc@gmail.com");
        //     var address = new Address("Rua John Locke", "137", "Aristocrata", "São José dos Pinhais", "PR", "BR", "83030280");
        //     var student = new Student(name, document, email);
        //     var subscription = new Subscription(null);
        //     var payment = new PayPalPayment("123456789", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Teste payer", document, null, email);

        //     subscription.AddPayment(payment);
        //     student.AddSubscription(subscription);
        //     student.AddSubscription(subscription);

        //     Assert.IsTrue(student.Invalid);
        // }
        public StudentTests()
        {
            _name = new Name("Rafael", "Rodrigues");
            _document = new Document("06606053927", EDocumentType.CPF);
            _email = new Email("rafaa.cfc@gmail.com");
            _address = new Address("Rua John Locke", "137", "Aristocrata", "São José dos Pinhais", "PR", "BR", "83030280");
            _student = new Student(_name, _document, _email);
            _subscription = new Subscription(null);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenActiveHadSubscription()
        {
            var payment = new PayPalPayment("123456789", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Teste payer", _document, null, _email);

            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            _student.AddSubscription(_subscription);
            Assert.IsTrue(_student.Invalid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var payment = new PayPalPayment("123456789", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "Teste payer", _document, null, _email);

            _subscription.AddPayment(payment);
            _student.AddSubscription(_subscription);

            Assert.IsTrue(_student.Valid);
        }

    }
}