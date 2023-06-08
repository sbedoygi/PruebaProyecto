﻿using System.ComponentModel.DataAnnotations;

namespace AyudasTecnologicas.DAL.Entities
{
    public class TemporalService : Entity
    {
        public ICollection<OrderDetailservices> OrderDetails { get; set; }

        public User User { get; set; }

        public TechnicalServices Product { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}")]
        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public float Quantity { get; set; }

        [DataType(DataType.MultilineText)]
        [Display(Name = "Comentarios")]
        public string? Remarks { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Valor")]
        public decimal Value => Product == null ? 0 : (decimal)Quantity * Product.Price;
    }
}
