using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErrorNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = string.Empty;

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}