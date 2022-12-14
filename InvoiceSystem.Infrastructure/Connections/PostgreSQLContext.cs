using Microsoft.EntityFrameworkCore;

namespace InvoiceSystem.Infrastructure.Connections;

public partial class PostgreSQLContext : DbContext
{
    public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options)
    {
    }
}
