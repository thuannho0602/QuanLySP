using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;
using QLSANPHAM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSANPHAM.DataAccess
{
    public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //    builder.Entity<IdentityUser>(entity => { entity.ToTable(name: "User"); });
        //}
    }
}
