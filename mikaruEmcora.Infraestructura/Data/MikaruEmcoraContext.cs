using Microsoft.EntityFrameworkCore;
using MikaruEmcora.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace MikaruEmcora.Infraestructure.Data {
    public class MikaruEmcoraContext : DbContext {
        public MikaruEmcoraContext(DbContextOptions options) : base(options) { }
        public DbSet<Media> MediaObjs {get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<EmailReceived> EmailsReceived { get; set; }

    }
}