using Microsoft.EntityFrameworkCore;

namespace CrudClientes.Models
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }


    }
}
