﻿using Books.DataAccess.Data;
using Books.DataAccess.Repository.IRepository;
using Books.Models;

namespace Books.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _context;
        public CompanyRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Company company)
        {
            _context.Update(company);
        }
    }
}
