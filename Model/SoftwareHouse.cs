using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SoftwareHouse
{
    public long Id { get; set; }
    public string? Nome { get; set; }
    public long Iva { get; set; }
    public string? Citta { get; set; }
    public string? Paese { get; set; }

    public IEnumerable<Videogame>? Videogames { get; set; }
}
