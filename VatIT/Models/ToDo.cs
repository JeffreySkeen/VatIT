using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VatIT.Models
{
    [DataContract]
    public class ToDo
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set;}
        [DataMember]
        public bool Completed { get; set; }
    }
}
