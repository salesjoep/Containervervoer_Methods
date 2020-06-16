using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Methods.Exceptions
{
    [Serializable]
    public class StackCapacityException : Exception
    {
        public StackCapacityException()
        {

        }

        public StackCapacityException(string message) : base(message)
        {

        }

        public StackCapacityException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected StackCapacityException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
