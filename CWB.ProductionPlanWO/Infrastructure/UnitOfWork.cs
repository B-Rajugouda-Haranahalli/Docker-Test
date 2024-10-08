﻿using System;
using System.Threading.Tasks;

namespace CWB.ProductionPlanWO.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly WODbContext _context;


        public UnitOfWork(WODbContext context)
        {
            this._context = context;
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
