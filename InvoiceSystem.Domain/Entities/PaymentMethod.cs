namespace InvoiceSystem.Domain.Entities;

public partial class PaymentMethod
{
    public short Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();
}
