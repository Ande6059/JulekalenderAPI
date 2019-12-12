using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JulekalenderAPI.Models
{
    public class Låge
    {
        public int LågeId { get; set; }
        public int Dag { get; set; }
        public string EksamensEmne { get; set; }
    }
}
