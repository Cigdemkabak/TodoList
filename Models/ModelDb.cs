using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Odev.Models
{
public class TodoAppContext : DbContext
    {

        public DbSet<Todo> Todos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=104.247.162.242\MSSQLSERVER2017;Database=akadem58_ck;User Id=akadem58_ck;Password=5Al33g$1f;TrustServerCertificate=True;");
    }
}
