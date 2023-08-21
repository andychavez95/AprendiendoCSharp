using System.ComponentModel.DataAnnotations;

namespace Bodega.Models.ViewModels
{
    public class BrandViewModel
    {
        [Required]
        [Display(Name = "Marca")]
        public string BrandName { get; set; }
    }
}

