using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription(null);
            //var student = new Student({FirstName = "Rafael", LastName = "Rodrigues", Document = "06606053927", Email = "rafaa.cfc@gmail.com"});
            var student = new Student("Rafael", "Rodrigues", "06606053927", "rafaa.cfc@gmail.com");

            student.AddSubscription(subscription);
        }
    }
}