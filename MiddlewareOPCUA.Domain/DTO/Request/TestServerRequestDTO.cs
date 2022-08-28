using System.Text.Json.Serialization;

namespace MiddlewareOPCUA.Domain.DTO.Request;
public class TestServerRequestDTO {
  [JsonPropertyName("ip")] public string IP{get;set;}
  [JsonPropertyName("porta")] public int Port{get;set;}
}
