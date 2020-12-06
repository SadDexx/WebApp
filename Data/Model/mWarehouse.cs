using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Model
{
    public class mWarehouse
    {
        [Key]
        public Guid wID { get; set; }

        public string wName { get; set; }

        public string wPos { get; set; }
    }
}
