using BuildingBlocks.Exceptions;

namespace Ordering.Application.Exception;

class OrderNotFoundException : NotFoundException
{
    public OrderNotFoundException(Guid id) : base("Order", id)
    {
    }
}
