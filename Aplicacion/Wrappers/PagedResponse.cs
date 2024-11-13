namespace Aplicacion.Wrappers
{
    public class PagedResponse<T> : Response<T>
{
    public int _pageNumer { get; set; }
    public int _pageSize { get; set; }

    public PagedResponse(T data, int pageNumer, int pageSize)
    {
        _pageNumer = pageNumer;
        _pageSize = pageSize;
        Data = data;
        Message = null;
        Succeeded = true;
        Errors = null;
    }
}
}