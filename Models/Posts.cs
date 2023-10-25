namespace InstigramApp.Models;
public class Posts{
    public int Id { get; set; }
    public string? Title { get; set; }
    public DateTime PostDate { get; set; }
    public string? Location { get; set; }
    public Tages? Tage { get; set; }
}