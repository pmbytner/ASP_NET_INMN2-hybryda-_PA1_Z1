using System.ComponentModel.DataAnnotations;

namespace ASP_NET_INMN2_hybryda__PA1_Z1.Models;

public class Miasto
{
    public int Id { get; set; }
    public string? Nazwa { get; set; }
    [DataType(DataType.Date)]
    public DateTime? DataZałożenia { get; set; }
    public decimal? Powierzchnia { get; set; }
    public ulong? Populacja { get; set; }
    public string? Województwo { get; set; }
}
