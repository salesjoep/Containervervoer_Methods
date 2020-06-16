using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer_Methods.Exceptions
{
    [Serializable]
    public class ShipRowException : Exception
    {
        public ShipRowException()
        {

        }

        public ShipRowException(string message) : base(message)
        {

        }

        public ShipRowException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public ShipRowException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
