using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class mGoods
    {
        [Key]
        public Guid GID {get; set;}
        public string gName { get; set; }

        public int gCount { get; set; }

        public int gWID { get; set; }
    }
}
