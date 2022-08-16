using Shopping.Aggregator.Models;

namespace Shopping.Aggregator.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<OrderResponseModel>?> GetOrdersByUsername(string username);
}