using System.ComponentModel.DataAnnotations;

namespace Bodega.Models.ViewModels
{
    public class BeerViewModel
    {
        [Required]
        [Display(Name = "Marca")]
        public int BrandId { get; set; } 
        
        [Required]
        [Display(Name = "Cerveza")]
        public string BeerName { get; set; }
    }
}