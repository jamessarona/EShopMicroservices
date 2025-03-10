namespace Shopping.Web.Services;

public interface ICatalogService
{
    Task<GetProductsResponse> GetProducts(int? pageNumber = 1, int? pageSize = 10);
    Task<GetProductByIdResponse> GetProduct(Guid id);
    Task<GetProductByCategoryResponse> GetProductsByCategory(string category);
}