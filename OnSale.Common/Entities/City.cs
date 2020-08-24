using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class City
{
    public int Id { get; set; }

    [MaxLength(50, ErrorMessage = "El Nombre del {0} debe contener menos de {1} caracteres")]
    [Required]
    public string Name { get; set; }

    [JsonIgnore]
    [NotMapped]
    public int IdDepartment { get; set; }
}
