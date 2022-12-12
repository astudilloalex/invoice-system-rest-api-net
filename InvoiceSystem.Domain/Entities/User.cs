namespace InvoiceSystem.Domain.Entities;

public partial class User
{
    public int Id { get; set; }

    public int PersonId { get; set; }

    public int EmailId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool AccountNonExpired { get; set; }

    public bool AccountNonLocked { get; set; }

    public bool CredentialsNonExpired { get; set; }

    public bool Enabled { get; set; }

    public DateTime CreationDate { get; set; }

    public DateTime UpdateDate { get; set; }

    public virtual Email? Email { get; set; }

    public virtual Person? Person { get; set; }

    public virtual ICollection<Establishment> Establishments { get; } = new List<Establishment>();

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
