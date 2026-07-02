using StackExchange.Redis;using System.Text.Json;using MovieApiLambda.Api.Models;
namespace MovieApiLambda.Api.Repositories;
public class RedisRepository{
 readonly IDatabase _db;
 public RedisRepository(IConnectionMultiplexer r)=>_db=r.GetDatabase();
 public async Task<Filme?> Get(int id){
   var v=await _db.StringGetAsync($"filme:{id}");
   return v.IsNullOrEmpty?null:JsonSerializer.Deserialize<Filme>(v!);
 }
 public Task Set(Filme f)=>_db.StringSetAsync($"filme:{f.Id}",JsonSerializer.Serialize(f),TimeSpan.FromMinutes(30));
}