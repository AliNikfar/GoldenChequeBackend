using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Domain.Entities
{
    public class FactorObjects : BaseEntity
    {
        public Int64 Price { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public Int64 Sum { get; set; }
        public List<Objectt> ObjectsList { get; set; }
        public Factor Factor;

    }
}
