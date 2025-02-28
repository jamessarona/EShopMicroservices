namespace Basket.API.Basket.StoreBasket;

public record GetBasketQuery(string UserName) : IQuery<GetBasketResult>;

public record GetBasketResult(ShoppingCart ShoppingCart);

public class GetBasketQueryHandler : IQueryHandler<GetBasketQuery, GetBasketResult>
{
    public async Task<GetBasketResult> Handle(GetBasketQuery query, CancellationToken cancellationToken)
    {
        //TODO: get basket from database
        //var basket = await _repository.GetBasket(request.UserName);

        return new GetBasketResult(new ShoppingCart("swn"));
    }
}