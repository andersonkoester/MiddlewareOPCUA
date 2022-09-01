using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiddlewareOPCUA.Domain.Entity;

[Table("tbl_server")]
public class ServerEntity{
  [Key]
  public string id{get;set;}

  public string str_tree{get;set;}
}
