using ProductManagement.Models;
using ProductManagement.Repositories.Interfaces;
using ProductManagement.Services.Interfaces;

namespace ProductManagement.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> GetAll() => _repo.GetAll();
        public Product? GetById(int id) => _repo.GetById(id);

        public void Add(Product product)
        {
            _repo.Add(product);
            _repo.Save();
        }

        public void Update(Product product)
        {
            _repo.Update(product);
            _repo.Save();
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
            _repo.Save();
        }
    }
}
