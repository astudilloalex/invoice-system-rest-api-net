using System.Text.Json.Serialization;

namespace InvoiceSystem.Domain.Entities;

public partial class Address
{
    public int Id { get; set; }

    public int CityId { get; set; }

    public string MainStreet { get; set; } = null!;

    public string? SecondaryStreet { get; set; }

    public string? HouseNumber { get; set; }

    public string? PostalCode { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public virtual City? City { get; set; }

    [JsonIgnore]
    public virtual ICollection<Establishment> Establishments { get; } = new List<Establishment>();
}
