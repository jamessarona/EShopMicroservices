namespace Shopping.Web.Models.Ordering;

public record OrderingModel(
    Guid Id,
    Guid CustomerId,
    string OrderName,
    AddressModel ShippingAddress,
    AddressModel BillingAddress,
    PaymentModel Payment,
    OrderStatus Status,
    List<OrderItemModel> OrderItems);

public record OrderItemModel(
    Guid OrderId,
    Guid ProductId,
    int Quantity,
    decimal Price);

public record AddressModel(
    string FirstName,
    string LastName,
    string EmailAddress,
    string AddressLine,
    string Country,
    string State,
    string ZipCode);
   
public record PaymentModel(string CardName,
    string CardNumber,
    string Expiration,
    string Cvv,
    int PaymentMethod);

public enum OrderStatus
{
    Draft = 1,
    Pending = 2,
    Completed = 3,
    CXancelled = 4
}

//wrapper clases
public record GetOrdersResponse(PaginatedResult<OrderingModel> Orders);
public record GetOrdersByNameResponse(IEnumerable<OrderingModel> Orders);
public record GetOrdersByCustomerResponse(IEnumerable<OrderingModel> Orders);