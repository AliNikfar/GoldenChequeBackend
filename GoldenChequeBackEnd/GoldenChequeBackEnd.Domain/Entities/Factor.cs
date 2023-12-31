﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Domain.Entities
{
    public class Factor : BaseEntity
    {
        public Person PersonCode { get; set; }
        public Int64 FactorSumPrice { get; set; }
        public int FactorSodDarsad { get; set; }
        public bool Visable { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastEdit { get; set; }
        public int LastHandleUser { get; set; }
        public DateTime FactorKharidDate { get; set; }
        public Int64 FactorSumObjectsPrice { get; set; }
        public int Kind { get; set; }
        public Int64 FactorBeforePrice { get; set; }
        public List<FactorObjects> FactorObjectList { get; set; }
        public List<Ghest> GhestList { get; set; }

    }
}
