using PruebaAyudasTecnologicas.DAL.Entities;

namespace PruebaAyudasTecnologicas.Models
{
    public class CityViewModel : City
    {
        public Guid StateId { get; set; }
    }
}
