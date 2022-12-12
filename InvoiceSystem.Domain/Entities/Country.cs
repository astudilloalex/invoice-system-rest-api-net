namespace InvoiceSystem.Domain.Entities;

public partial class Country
{
    public short Id { get; set; }

    public string Alpha2Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<City> Cities { get; } = new List<City>();

    public virtual ICollection<DialInCode> DialInCodes { get; } = new List<DialInCode>();
}
