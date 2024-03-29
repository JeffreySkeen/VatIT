﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VatIT.Results
{
    [DataContract]
    public class GetTodosResult
    { 
        public GetTodosResult(IList<Models.ToDo> todos) 
        {
            ToDos = todos;
        }
        [DataMember]
        public IList<Models.ToDo> ToDos { get; set; }
    }
}
