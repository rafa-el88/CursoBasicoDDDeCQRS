using System;
using PaymentContext.Domain.Enums;
using ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }

        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public static implicit operator Document(string v)
        {
            throw new NotImplementedException();
        }
    }
}