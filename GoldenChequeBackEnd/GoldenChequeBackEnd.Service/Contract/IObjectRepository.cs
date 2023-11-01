
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IObjectRepository
    {
        bool Insert(Objectt objectt);

        bool update(Objectt objectt);

        bool delete(int objectId);

        List<Objectt> GetAll();

        Objectt GetById(int id);
    }
}
