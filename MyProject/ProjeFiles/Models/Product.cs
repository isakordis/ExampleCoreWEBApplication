using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeFiles.Models
{
    public class Product
    {
        [Key]
        public int guid { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public int prize { get; set; }

    }
}
