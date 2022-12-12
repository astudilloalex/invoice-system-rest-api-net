namespace InvoiceSystem.Domain.Entities;

public partial class ProductCategory
{
    public short Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
