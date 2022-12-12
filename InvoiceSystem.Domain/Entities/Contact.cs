namespace InvoiceSystem.Domain.Entities;

public partial class Contact
{
    public int Id { get; set; }

    public int? PhoneId { get; set; }

    public int? EmailId { get; set; }

    public bool Main { get; set; }

    public virtual Email? Email { get; set; }

    public virtual Phone? Phone { get; set; }

    public virtual ICollection<Customer> Customers { get; } = new List<Customer>();

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

    public virtual ICollection<Establishment> Establishments { get; } = new List<Establishment>();

    public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
}
