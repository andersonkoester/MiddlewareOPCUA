using Microsoft.AspNetCore.Mvc;
using MiddlewareOPCUA.API.Config;
using MiddlewareOPCUA.Domain.DTO.Request;
using MiddlewareOPCUA.Domain.DTO.Response;

namespace MiddlewareOPCUA.API.Controllers;

[Route("server/")]
public class ServerController : APIControllerBase {

  [HttpGet]
  [Route("")]
  public async Task<object> GetServers() {
    return null;
  }

  [HttpGet]
  [Route("{uuid}")]
  public async Task<object> GetServerByUUID( [FromRoute] string UUID ) {
    return null;
  }

  [HttpPost]
  [Route("test-server")]
  public async Task<TestServerResponseDTO> TestServer( [FromBody] TestServerRequestDTO request ) {
    return null;
  }

}
