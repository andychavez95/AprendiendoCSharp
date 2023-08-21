using System;
using System.Collections.Generic;

namespace Bodega.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Beers = new HashSet<Beer>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; } = null!;

        public virtual ICollection<Beer> Beers { get; set; }
    }
}
