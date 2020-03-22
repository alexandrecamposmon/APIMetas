using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMetas.Model
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Meta> Metas { get; set; }
        public DbSet<TipoMeta> TipoMetas { get; set; }
        public DbSet<StatusMeta> StatusMetas { get; set; }
    }
}
