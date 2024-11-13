namespace Aplicacion.Parameters
{
    public class RequestParameter
    {
        public int PageNumer { get; set; }
        public int PageSize { get; set; }

        public RequestParameter()
        {
            PageNumer = 1;
            PageSize = 10;
        }
        public RequestParameter(int pageNumer, int pageSize)
        {
            PageNumer = pageNumer < 1 ? 1 : pageNumer;
            PageSize = pageSize > 10 ? 10 : pageSize;
        }

    }
}