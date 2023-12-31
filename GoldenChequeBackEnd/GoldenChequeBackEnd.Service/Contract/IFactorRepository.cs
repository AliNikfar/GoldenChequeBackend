﻿
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IFactorRepository
    {
        bool Insert(Factor factor);

        bool update(Factor factor);

        bool delete(int factorId);

        List<Factor> GetAll();

        Factor GetById(int id);
    }
}
