using GoldenChequeBackEnd.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenChequeBackEnd.Domain.Entities
{
    public  class User : BaseEntity
    {
        public int  UserId
        {
            get;
            set;
        }

        public int UserName
        {
            get;
            set;
        }
        //public Roles Role;
    }
}
