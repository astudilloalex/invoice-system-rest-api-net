using System.Text.Json.Serialization;

namespace InvoiceSystem.Domain.Entities;

public partial class Email
{
    public int Id { get; set; }

    public string Mail { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();

    [JsonIgnore]
    public virtual User? User { get; set; }

}
