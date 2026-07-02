using Amazon.Lambda.APIGatewayEvents;using System.Text.Json;
namespace MovieApiLambda.Api;
public class Function{
 public async Task<APIGatewayProxyResponse> Handler(APIGatewayProxyRequest req){
   return new(){StatusCode=200,Body=JsonSerializer.Serialize(new{message="Implement DI here"})};
 }}