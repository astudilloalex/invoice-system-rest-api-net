using System.Text.Json.Serialization;

namespace InvoiceSystem.Domain.Entities;

public partial class City
{
    public int Id { get; set; }

    public short CountryId { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    [JsonIgnore]
    public virtual ICollection<Address> Addresses { get; } = new List<Address>();

    public virtual Country? Country { get; set; }
}
