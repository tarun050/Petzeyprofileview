using Microsoft.EntityFrameworkCore;
using Petzey.ProfileView.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petzey.ProfileView.Data.DataAcess
{
    public class ProfileViewsDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:petzeyproject.database.windows.net,1433;Initial Catalog=Petzey-Vet;Persist Security Info=False;User ID=Tarun_050;Password=Relax@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
       public DbSet<ProfileViews> Profiles { get; set; }
    }
}
