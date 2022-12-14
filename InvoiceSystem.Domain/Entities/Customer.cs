namespace InvoiceSystem.Domain.Entities;

public partial class Customer
{
    public int PersonId { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual ICollection<Invoice> Invoices { get; } = new List<Invoice>();

    public virtual Person? Person { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();
}
