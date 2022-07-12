using Ploomes.Domain.Entities;
using Ploomes.Infra.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Ploomes.Infra.Context{
    public class PloomesContext : DbContext{
        public PloomesContext()
        {}

        public PloomesContext(DbContextOptions<PloomesContext> options) : base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Data Source = DESKTOP-DA6MBAT\SQLEXPRESS; Initial Catalog= Ploomes; User Id=sa; Password=ps132");
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserMap());
        }
    }
} 