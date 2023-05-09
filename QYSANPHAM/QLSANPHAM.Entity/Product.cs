using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSANPHAM.Entity
{
    [Table("Product")]
    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public string ProductDescription { get; set; }
        public string Origin { get; set; }
        public string Trademark { get; set; }
        public string Memory { get; set; }
        public string TheBattery { get; set; }
        public decimal Price { get; set; }
        public string Promotion { get; set; }
        public int TheRemainingAmount { get; set; }
    }
}
