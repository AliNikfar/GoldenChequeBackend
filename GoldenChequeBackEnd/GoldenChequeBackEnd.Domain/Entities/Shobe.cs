﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Domain.Entities
{
    public class Shobe : BaseEntity
    {
        public int Name { get; set; }
        public int code { get; set; }

    }
}
