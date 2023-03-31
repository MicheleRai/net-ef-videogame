using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.Model
{
    [Table("softwareHouse")]
    public class SoftwareHouse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long NumeroPIva { get; set; }
        public string? Citta { get; set; }
        public string? Nazione { get; set; }

        public IEnumerable<Videogame>? Videogames { get; set; }
    }
}
