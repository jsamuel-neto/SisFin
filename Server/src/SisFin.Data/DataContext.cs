using Microsoft.EntityFrameworkCore;

namespace SisFin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
            base.OnModelCreating(model);
        }
    }
}