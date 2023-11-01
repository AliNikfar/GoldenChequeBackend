using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Domain.Entities
{
    public class Bank:BaseEntity
    {
        public string Title { get; set; }

        public List<Shobe> ShobeList {get; set;}
    }
}
