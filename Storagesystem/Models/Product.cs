using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Storagesystem.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Range (0,int.MaxValue)]
        [DisplayFormat(DataFormatString ="{0:C}")]

        public int Price { get; set; }
        [Display(Name="Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy:MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime Orderdate { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText ="-")]
        public string Category { get; set; }
        public string Shelf { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "-")]
        public string Description { get; set; }

    }
}
