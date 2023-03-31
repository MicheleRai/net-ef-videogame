using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

[Table("videogames")]

[Index(nameof(Id), IsUnique = true)]
public class Videogame
{
    public long Id { get; set; }
    public string? Nome { get; set; }
    public string? Trama { get; set; }
    public DateTime DataUscita { get; set; }
    public long SoftwareHouseId { get; set; }
    public SoftwareHouse? SoftwareHouse { get; set; }

    public override string ToString()
    {
        var nl = Environment.NewLine;
        return $"Id: {Id} {nl}" +
            $"Name: {Nome} {nl}" +
            $"Overview: {Trama}{nl}" +
            $"Release date: {DataUscita}{nl}" +
            $"Software house id: {SoftwareHouseId}";
    }
}
