namespace InstigramApp.Controllers;
using InstigramApp.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/posts")]
public class PostsController:ControllerBase
{
    private readonly PostsRepository postsRepository;

    public PostsController(PostsRepository postsRepository)
    {
        this.postsRepository = postsRepository;
    }

    [HttpGet]
    public List<Posts> posts(){
        return postsRepository.GetAllPosts();

    }
    [HttpPut("{id:int}")]
    public void UpdateOnePost(int id,Posts posts){
         postsRepository.UpdateOnePost(id,posts);
    }
    [HttpDelete("{id:int}")]
    public void DelteOnePost(int id){
         postsRepository.DeleteOnePost(id);
    }
    [HttpPost()]
    public void CreateOnePost(Posts posts){
         postsRepository.CreateOnePost(posts);
    }
    [HttpDelete()]
    public void DeleteAllPost(int id){
         postsRepository.DeleteOnePost(id);
    }
}
    
