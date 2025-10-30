using ProductManagement.Data;
using ProductManagement.Models;
using ProductManagement.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll() => _context.Products.AsNoTracking().ToList();
        public Product? GetById(int id) => _context.Products.Find(id);
        public void Add(Product product) => _context.Products.Add(product);
        public void Update(Product product) => _context.Products.Update(product);
        public void Delete(int id)
        {
            var p = _context.Products.Find(id);
            if (p != null) _context.Products.Remove(p);
        }
        public void Save() => _context.SaveChanges();
    }
}

