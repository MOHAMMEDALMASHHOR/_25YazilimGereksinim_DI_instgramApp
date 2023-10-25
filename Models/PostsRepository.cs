using Microsoft.AspNetCore.Components.Web;
namespace InstigramApp.Models;

public class PostsRepository{
    private List<Posts> postsList;
    public List<Posts> GetAllPosts(){
        return postsList;
    }
    public Posts GetOnePost(int id){
        foreach (var item in postsList)
        {
            if (item.Id.Equals(id))
            {
                return item;
                
            }
        }
        throw new Exception("404");
    }
    public void DeleteOnePost(int id){
        foreach (var item in postsList)
        {
            if (item.Id.Equals(id))
            {
                 postsList.Remove(item);
                
            }
        }
        throw new Exception("404");
    }
    public void CreateOnePost(Posts posts){
        postsList.Add(posts);
    }
    public void UpdateOnePost(int id, Posts posts){
        for (int i = 0; i < postsList.Count; i++)
        {
            if (postsList[i].Id.Equals(id))
            {
                postsList[i]= posts;
            }
        }
        /* var item = GetOnePost(id);
        item.Id = posts.Id;
        item.Title = posts.Title;
        item.Location = posts.Location;
        item.PostDate = posts.PostDate;
        item.Tage = posts.Tage; */
        throw new Exception("404");
        
    }
    public void DeleteAllPosts(){
        postsList.Clear();
    }
    
    public PostsRepository()
    {
        postsList = new List<Posts>();
        postsList.Add(new Posts(){Id = 1, Title ="Lesson", Location="samsun", PostDate =DateTime.Now,Tage = new Tages(){Id =11,TagName = "Mohammed"}});
        postsList.Add(new Posts(){Id = 2, Title ="Tatil", Location="Van", PostDate =DateTime.Now,Tage = new Tages(){Id =11,TagName = "Mohammed"}});
    }

}