using Ploomes.Domain.Entities;
using Ploomes.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Ploomes.Infra.Context{
    public class PloomesContext : DbContext{
        public PloomesContext()
        {}

        public PloomesContext(DbContextOptions<PloomesContext> options) : base(options)
        {}

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
} 