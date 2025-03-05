namespace BuildingBlocks.Pagination;

public class PaginatedResult<TEntity>
    (int pageIndex, int PageSize, long count, IEnumerable<TEntity> data) 
    where TEntity : class
{
    public int PageIndex { get; } = pageIndex;
    public int PageSize { get; } = PageSize;
    public long Count { get; } = count;
    public IEnumerable<TEntity> Data { get; } = data;
}