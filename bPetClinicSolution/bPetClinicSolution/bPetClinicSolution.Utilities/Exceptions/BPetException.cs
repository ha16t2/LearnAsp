using System;
using System.Collections.Generic;
using System.Text;

namespace bPetClinicSolution.Utilities.Exceptions
{
    public class BPetException:Exception
    {
        public BPetException()
        {
        }

        public BPetException(string message)
            : base(message)
        {
        }

        public BPetException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
