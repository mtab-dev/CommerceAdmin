using CommerceAdmin.API.DTO.Request;
using CommerceAdmin.API.Entities;

namespace CommerceAdmin.API.Abstractions
{
    public interface IProductUseCase
    {
        Task<ProductEntity> RegisterProductAsync(RegisterProductDTO dto);
        Task<ProductEntity> GetProductBySkuAsync(string sku);
        Task<ProductEntity> GetAllProducts();
    }
}
