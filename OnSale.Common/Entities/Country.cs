using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
   public class Country
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage ="El Nombre del {0} debe contener menos de {1} caracteres")]
        [Required]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }

        [DisplayName("Numero de Provincias")]
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;

    }
}
