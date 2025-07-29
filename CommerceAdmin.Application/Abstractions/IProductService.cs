using CommerceAdmin.Application.DTO.Request;
using CommerceAdmin.Domain.Entities;

namespace CommerceAdmin.Application.Abstractions
{
    public interface IProductService
    {
        Task<ProductEntity> RegisterProductAsync(RegisterProductDTO dto);
        Task<ProductEntity> GetProductBySkuAsync(string sku);
        Task<ProductEntity> GetAllProducts();
        Task<ProductEntity> GetProductByCategory(string category);
    }
}
