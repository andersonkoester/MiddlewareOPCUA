using System.Text.Json.Serialization;

namespace MiddlewareOPCUA.Domain.DTO.Response;

public class TestServerResponseDTO{
  [JsonPropertyName("ip")] public string IP{get;set;} = String.Empty;
  [JsonPropertyName("porta")] public int Port{get;set;}
  [JsonPropertyName("conectavel")] public bool IsConnectable{get;set;}
}
