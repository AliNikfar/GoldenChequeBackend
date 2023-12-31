﻿using System;
using System.Collections.Generic;
using GoldenCheque.Service.Contract;
using System.Linq;
using System.Threading.Tasks;
using GoldenCheque.Domain.Entities;
using GoldenCheque.Persistence;

namespace GoldenCheque.Service.Implementation
{
    public class GhestRepository : IGhestRepository
    {
        private readonly ApplicationDbContext _ctx;
        public GhestRepository(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        public bool delete(int GhestId)
        {
            try
            {
                Ghest bsi = _ctx.Ghests.Where(p => p.Id == GhestId).FirstOrDefault();
                _ctx.Ghests.Remove(bsi);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<Ghest> GetAll()
        {
            return _ctx.Ghests.ToList();
        }

        public List<Ghest> GetByFactorId(int Factorid)
        {
            return _ctx.Ghests.Where(p => p.Factor.Id == Factorid).ToList();
        }

        public Ghest GetById(int id)
        {
            return _ctx.Ghests.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool Insert(Ghest ghest)
        {
            try
            {
                _ctx.Ghests.Add(ghest);
                _ctx.SaveChanges();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public bool update(Ghest ghest)
        {
            try
            {
                _ctx.Ghests.Attach(ghest);
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
