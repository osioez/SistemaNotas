using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SistemaNotas.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        [Required (ErrorMessage ="Campor Requerido")]
        [StringLength (50, ErrorMessage = "El nombre debe tener de 3 a 50 caracteres")]
        public string Nombre { get; set; }
        [StringLength(256, ErrorMessage = "Su descripccion no debe sobre pasar los 256 caracteres")]
        [Display(Name ="Descripcion")]
        public string Descripccion { get; set; }
        public Boolean Estado { get; set; }
    }
}
