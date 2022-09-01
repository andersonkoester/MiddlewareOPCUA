using Microsoft.EntityFrameworkCore;
using MiddlewareOPCUA.Domain.Entity;

namespace MiddlewareOPCUA.Domain.Interface;

public interface IApplicationDBContext{
  DbSet<ServerEntity> servers{get;}
}
