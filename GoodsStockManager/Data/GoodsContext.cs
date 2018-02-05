using GoodsStockManager.API.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GoodsStockManager.API.Data
{
    public class GoodsContext: DbContext
    {
        public GoodsContext()
        {
        }

        public GoodsContext(DbContextOptions<GoodsContext> options) : base(options)
        {}

        public DbSet<GoodsItem> Courses { get; set; }
    }
}
