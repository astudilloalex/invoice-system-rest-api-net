namespace InvoiceSystem.Domain.Entities;

public partial class DialInCode
{
    public short Id { get; set; }

    public short CountryId { get; set; }

    public string Code { get; set; } = null!;

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Phone> Phones { get; } = new List<Phone>();
}
