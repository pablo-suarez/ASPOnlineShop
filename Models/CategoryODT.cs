using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace OnlineShop.Models
{
    public class CategoryODT
    {
        public int IdCategory { get; set; }
        [Required(ErrorMessage="Nombre de Categoria Requerido")]
        [StringLength(100,ErrorMessage ="Minimo 3 maximo 100 caracteres permitidos"),MinLength(3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Isdelete { get; set; }
    }
    public class ProductDetail
    {
        public int IdProduct { get; set; }
        [Required(ErrorMessage = "Nombre de Producto Requerido")]
        [StringLength(100, ErrorMessage = "Minimo 5 maximo 100 caracteres permitidos"), MinLength(5)]
        public string Name { get; set; }
        public Nullable<int> IdCategory { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Isdelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        [Required(ErrorMessage = "Descripcion Requerida")]
        public string Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> Isfeatured { get; set; }
        [Required]
        [Range(typeof(int),"1","500",ErrorMessage = "Cantidad Invalida")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Precio Invalido")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }

    }
}