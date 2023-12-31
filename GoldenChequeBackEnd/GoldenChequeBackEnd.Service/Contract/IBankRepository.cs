﻿
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IBankRepository
    {
        //IEnumerable<Bank> Reservations { get; }



        Bank Insert (Bank bank);

        Bank update (Bank bank);

        bool delete(int bankId);
 
        List<Bank> GetAll();

        Bank GetById(int id);
    }
}
