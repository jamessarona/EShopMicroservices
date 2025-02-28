namespace Basket.API.Basket.StoreBasket;

public record  GetBasketQuery(string UserName) : IQuery<GetBasketResult>;

public record GetBasketResult(ShoppingCart ShoppingCart);

public class StoreBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery request, CancellationToken cancellationToken)
    {
        //TODO: get basket from database
        //var basket = await _repository.GetBasket(request.UserName);

        return new GetBasketResult(new ShoppingCart("swn"));
    }
}