using net_ef_videogame.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.Model
{
    [Table("videogame")]
    public class Videogame
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Overview { get; set; }
        public DateTime ReleaseDate { get; set; }

        public int SoftwareHouseId { get; set; }
        public SoftwareHouse? SoftwareHouse { get; set; }
    }
}
