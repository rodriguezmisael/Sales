namespace Sales.Domain.Models
{
    using Sales.Common.Models;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext
    {
        public readonly IQueryable<Product> Product;

        public DataContext() : base("DefaultConnection")
        {
        }

        //public System.Data.Entity.DbSet<Sales.Common.Models.Product> Products { get; set; }
    }
}
