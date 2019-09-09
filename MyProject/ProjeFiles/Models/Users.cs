using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeFiles.Models
{
    public class Users
    {
        [Key]
        public int guid { get; set; }
        public string userName { get; set; }
        public string userPass { get; set; }

    }
}
