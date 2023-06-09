﻿using System.ComponentModel.DataAnnotations;

namespace PruebaAyudasTecnologicas.Models
{
    public class AddProductImageViewModel
    {
        public Guid ProductId { get; set; }

        [Display(Name = "Foto")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public IFormFile ImageFile { get; set; }
    }
}

