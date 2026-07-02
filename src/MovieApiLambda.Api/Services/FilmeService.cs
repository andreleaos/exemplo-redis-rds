using MovieApiLambda.Api.Models;using MovieApiLambda.Api.Repositories;
namespace MovieApiLambda.Api.Services;
public class FilmeService{
 readonly RedisRepository _r; readonly FilmeRepository _f;
 public FilmeService(RedisRepository r,FilmeRepository f){_r=r;_f=f;}
 public async Task<Filme?> Get(int id){
   var c=await _r.Get(id); if(c!=null)return c;
   var db=await _f.Get(id); if(db!=null)await _r.Set(db); return db;
 }}