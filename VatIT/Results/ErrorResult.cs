using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VatIT.Results
{
    [DataContract]
    public class ErrorResult
    {
        public ErrorResult(string message)
        {
            Message = message;
        }

        [DataMember]
        public string Message
        {
            get; set;
        }
    }
}
