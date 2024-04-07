using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet para a entidade Cliente
    public DbSet<Cliente> Clientes { get; set; }

    // DbSet para a entidade Logradouro
    public DbSet<Logradouro> Logradouros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração do relacionamento entre Cliente e Logradouro
        modelBuilder.Entity<Logradouro>()
            .HasOne(l => l.Cliente)
            .WithMany(c => c.Logradouros)
            .HasForeignKey(l => l.ClienteId);

        // Restrição de unicidade para o campo Email na entidade Cliente
        modelBuilder.Entity<Cliente>()
            .HasIndex(c => c.Email)
            .IsUnique();
    }
}
