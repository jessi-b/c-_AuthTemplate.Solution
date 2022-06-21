using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProjectName.Models {
  public class ProjectNameContext : DbContext {
    public DbSet<ClassName> ClassNames { get; set; }
    public ProjectNameContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}