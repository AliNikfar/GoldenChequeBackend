
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IUnitsRepository
    {
        bool Insert(Units units);

        bool update(Units units);

        bool delete(int unitsId);

        List<Units> GetAll();

        Units GetById(int id);

    }
}
