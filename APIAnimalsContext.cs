using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using safariapi.Models;

namespace safariapi
{
  public partial class APIAnimalsContext : DbContext
  {
    public APIAnimalsContext()
    {
    }

    public APIAnimalsContext(DbContextOptions<APIAnimalsContext> options)
        : base(options)
    {
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        optionsBuilder.UseNpgsql("server=localhost;database=APIAnimals;User Id=dev;Password=dev");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");
    }

    public DbSet<APIAnimals> APIAnimals { get; set; }
    public object Species { get; internal set; }
  }
}
