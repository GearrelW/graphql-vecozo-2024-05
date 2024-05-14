namespace VecozoApi.Entities;

public class StreamingShow : IShow
{
    public int Id { get; set; }

    public string Title { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public IEnumerable<Episode> Episodes { get; set; }

    public bool IsInteractive { get; set; } // Black MIrror Bandersnatch

    public bool ViewInAnyOrder { get; set; } // Kaleidoscope

    public int MinimumAge { get; set; }
}
