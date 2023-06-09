
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;



namespace PruebaAyudasTecnologicas.Models
{
    public class AddTechnicalServicesViewModel
    {
        public Guid ProductId { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public Guid CategoryId { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; } //Necesito la lista de las categorías para seleccionar una nueva categoría
    }
}
