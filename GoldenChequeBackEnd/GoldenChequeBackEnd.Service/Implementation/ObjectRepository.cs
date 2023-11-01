using System;
using System.Collections.Generic;
using GoldenCheque.Service.Contract;
using System.Linq;
using System.Threading.Tasks;
using GoldenCheque.Domain.Entities;
using GoldenCheque.Persistence;

namespace GoldenCheque.Service.Implementation
{
    public class ObjectRepository : IObjectRepository
    {
        private readonly ApplicationDbContext _ctx;
        public ObjectRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool delete(int ObjectId)
        {
            try
            {
                Objectt bsi = _ctx.Objects.Where(p => p.Id == ObjectId).FirstOrDefault();
                _ctx.Objects.Remove(bsi);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Objectt> GetAll()
        {
            return _ctx.Objects.ToList();
        }

        public Objectt GetById(int id)
        {
            return _ctx.Objects.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Insert(Objectt objectt)
        {
            try
            {
                _ctx.Objects.Add(objectt);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool update(Objectt objectt)
        {
            try
            {
                _ctx.Objects.Attach(objectt);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
