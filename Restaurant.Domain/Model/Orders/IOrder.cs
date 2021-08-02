using Restaurant.Domain.Model.Products;

namespace Restaurant.Domain.Model.Orders
{
    public interface IOrder
    {
        void AddProduct(Product product);
    }
}
