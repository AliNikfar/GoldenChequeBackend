
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IShobeRepository
    {
        bool Insert(Shobe shobe);

        bool update(Shobe shobe);

        bool delete(int shobeId);

        List<Shobe> GetAll();

        Shobe GetById(int id);

        List<Shobe> GetByBankId(int bankId);
    }
}
