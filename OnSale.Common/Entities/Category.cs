using System;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Common.Entities
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "El Nombre del {0} debe contener menos de {1} caracteres")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://onsaleeddy.azurewebsites.net/images/noimage.png"
            : $"https://onsaleeddy.blob.core.windows.net/categories/{ImageId}";
    }

}
