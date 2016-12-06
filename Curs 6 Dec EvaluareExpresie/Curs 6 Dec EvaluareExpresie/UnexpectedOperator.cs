using System;
using System.Runtime.Serialization;

namespace Curs_6_Dec_EvaluareExpresie
{
    [Serializable]
    internal class UnexpectedOperator : Exception
    {
        public UnexpectedOperator()
        {
        }

        public UnexpectedOperator(string message) : base(message)
        {
        }

        public UnexpectedOperator(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnexpectedOperator(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}