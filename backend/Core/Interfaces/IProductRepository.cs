using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(int id); 
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
        
    }
}