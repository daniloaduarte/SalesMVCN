using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeBMvc.Data;
using SalesWeBMvc.Models;

namespace SalesWeBMvc.Services
{
    public class SellerService
    {
        private readonly SalesWeBMvcContext _context;

        public SellerService(SalesWeBMvcContext context)
        {
            _context = context;
        }
        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
