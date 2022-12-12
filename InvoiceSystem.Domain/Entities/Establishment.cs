namespace InvoiceSystem.Domain.Entities;

public partial class Establishment
{
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public int AddressId { get; set; }

    public string? Code { get; set; }

    public string Name { get; set; } = null!;

    public bool Parent { get; set; }

    public bool Active { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Address? Address { get; set; }

    public virtual Company? Company { get; set; }

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();

    public virtual ICollection<User> Users { get; } = new List<User>();
}
