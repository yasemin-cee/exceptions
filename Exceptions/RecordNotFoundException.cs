using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message): base(message)  // ana programda mesajın yazılabilmesi için !! 
        {
            
        }

    }
}
