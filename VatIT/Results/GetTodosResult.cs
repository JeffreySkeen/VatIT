using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VatIT.Results
{
    [DataContract]
    public class GetTodosResult
    {
        [DataMember]
        public IList<ToDo> ToDos { get; set; }
    }
}
