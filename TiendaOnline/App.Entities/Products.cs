using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price{ get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public DateTime UpDate { get; set; }
    }
}
