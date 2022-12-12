namespace InvoiceSystem.Domain.Entities;

public partial class Phone
{
    public int Id { get; set; }

    public short DialInCodeId { get; set; }

    public string Number { get; set; } = null!;

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();

    public virtual DialInCode? DialInCode { get; set; }
}
