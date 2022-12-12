namespace InvoiceSystem.Domain.Entities;

public partial class Company
{
    public int Id { get; set; }

    public int? ParentCompanyId { get; set; }

    public int PersonId { get; set; }

    public string Tradename { get; set; } = null!;

    public string? ImageUrl { get; set; }

    public bool KeepAccounts { get; set; }

    public bool SpecialTaxpayer { get; set; }

    public string? SpecialTaxpayerNumber { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<Establishment> Establishments { get; } = new List<Establishment>();

    public virtual ICollection<Company> InverseParentCompany { get; } = new List<Company>();

    public virtual Company? ParentCompany { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
