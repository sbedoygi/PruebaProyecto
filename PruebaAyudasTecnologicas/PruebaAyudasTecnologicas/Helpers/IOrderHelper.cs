using PruebaAyudasTecnologicas.Common;
using PruebaAyudasTecnologicas.Models;


namespace PruebaAyudasTecnologicas.Helpers
{
    public interface IOrderHelper
    {
        Task<Response> ProcessOrderAsync(ShowCartViewModel showCartViewModel);
    }
}
