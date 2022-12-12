namespace InvoiceSystem.Domain.Entities;

public partial class Invoice
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public short PaymentMethodId { get; set; }

    public string Code { get; set; } = null!;

    public DateTime DateTime { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();

    public virtual PaymentMethod? PaymentMethod { get; set; }
}
