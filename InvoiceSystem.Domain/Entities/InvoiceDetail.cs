namespace InvoiceSystem.Domain.Entities;
public partial class InvoiceDetail
{
    public int Id { get; set; }

    public int InvoiceId { get; set; }

    public int ProductId { get; set; }

    public double Quantity { get; set; }

    public decimal Cost { get; set; }

    public double ProfitPercentage { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ICollection<Tax> Taxes { get; } = new List<Tax>();
}
