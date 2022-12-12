namespace InvoiceSystem.Domain.Entities;

public partial class Person
{
    public int Id { get; set; }

    public short DocumentTypeId { get; set; }

    public short? GenderId { get; set; }

    public string IdCard { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateOnly? Birthdate { get; set; }

    public string? SocialReason { get; set; }

    public bool JuridicalPerson { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual Customer? Customer { get; set; }

    public virtual PersonDocumentType? DocumentType { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Gender? Gender { get; set; }

    public virtual Supplier? Supplier { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
