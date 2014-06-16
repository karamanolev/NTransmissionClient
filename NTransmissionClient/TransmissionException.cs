using System;
using System.Linq;

namespace NTransmissionClient
{
    public class TransmissionException : Exception
    {
        public TransmissionException(string message)
            : base(message)
        { }
    }
}