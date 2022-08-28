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
  public async Task<object> GetServerByUUID([FromRoute] string UUID) {
    return null;
  }

  [HttpPost]
  [Route("")]
  public async Task<TestServerResponseDTO> GetServerByUUID([FromBody] TestServerRequestDTO request) {
    return null;
  }

}
