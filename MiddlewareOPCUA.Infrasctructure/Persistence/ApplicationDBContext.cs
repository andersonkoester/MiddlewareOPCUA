using Microsoft.EntityFrameworkCore;
using MiddlewareOPCUA.Domain.Entity;
using MiddlewareOPCUA.Domain.Interface;

namespace MiddlewareOPCUA.Infrastructure.Persistence;
public class ApplicationDBContext : DbContext, IApplicationDBContext{
  public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){}

  public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken()){
    var result = await base.SaveChangesAsync(cancellationToken);

    return result;
  }
  /* ENTITIES */
  public DbSet<ServerEntity> servers {get;set;}
}
