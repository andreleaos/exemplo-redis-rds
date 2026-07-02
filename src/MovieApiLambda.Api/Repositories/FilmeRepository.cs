using Dapper;using MySqlConnector;using MovieApiLambda.Api.Models;
namespace MovieApiLambda.Api.Repositories;
public class FilmeRepository{
 readonly string _cs;
 public FilmeRepository(string cs)=>_cs=cs;
 public async Task<Filme?> Get(int id){
   using var c=new MySqlConnection(_cs);
   return await c.QueryFirstOrDefaultAsync<Filme>("select * from filmes where id=@id",new{id});
 }}