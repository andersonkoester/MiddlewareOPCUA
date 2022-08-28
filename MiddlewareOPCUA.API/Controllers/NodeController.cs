using Microsoft.AspNetCore.Mvc;
using MiddlewareOPCUA.API.Config;
using MiddlewareOPCUA.Domain.DTO.Request;
using MiddlewareOPCUA.Domain.DTO.Response;

namespace MiddlewareOPCUA.API.Controllers;

[Route("node/")]
public class NodeController : APIControllerBase {

  [HttpGet]
  [Route("{path}")]
  public async Task<object> GetNode([FromRoute] string path) {
    return null;
  }

}
