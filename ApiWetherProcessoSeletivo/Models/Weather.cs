using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiWetherProcessoSeletivo.Models
{
    public class Wether
    {
        public int Id { get; set; }
        public string Cidade { get; set; }
        public string MinTemp { get; set; }
        public string MaxTemp { get; set; }
        public string CurrentTemp { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
