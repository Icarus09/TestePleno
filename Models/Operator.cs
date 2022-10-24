using System;
using System.Collections.Generic;
using System.Text;

namespace TestePleno.Models
{
    public class Operator : IModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
    }
}
