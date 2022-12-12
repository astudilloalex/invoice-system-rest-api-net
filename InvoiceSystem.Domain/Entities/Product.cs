namespace InvoiceSystem.Domain.Entities;

public partial class Product
{
    public int Id { get; set; }

    public short? CategoryId { get; set; }

    public short TypeId { get; set; }

    public string? Barcode { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Presentation { get; set; }

    public string? Content { get; set; }

    public decimal Cost { get; set; }

    public double ProfitPercentage { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ICollection<InvoiceDetail> InvoiceDetails { get; } = new List<InvoiceDetail>();

    public virtual ProductType? Type { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Tax> Taxes { get; } = new List<Tax>();
}
