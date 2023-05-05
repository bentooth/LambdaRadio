
namespace LambdaRadio.Models;

public class PlaylistItem
{
    public int Id { get; set; }
    public int StreamId { get; set; }
    public string Title { get; set; }
    public string Cover { get; set; }
    public int Duration { get; set; }
}
