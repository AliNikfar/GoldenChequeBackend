
using GoldenCheque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldenCheque.Service.Contract
{
    public interface IPersonRepository
    {
        bool Insert(Person person);

        bool update(Person person);

        bool delete(int personId);

        List<Person> GetAll();

        Person GetById(int id);
    }
}
