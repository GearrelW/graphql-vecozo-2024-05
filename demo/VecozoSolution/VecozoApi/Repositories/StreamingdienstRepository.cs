using VecozoApi.Entities;

namespace VecozoApi.Repositories;

public class StreamingdienstRepository : IStreamingdienstRepository
{
    private static List<StreamingShow> s_shows = new()
    {
        new()
        {
            Id = 23,
            Title = "Black Mirror Bandersnatch",
            ReleaseDate = new DateOnly(2021, 1, 1),
            MinimumAge = 16
        },
        new()
        {
            Id = 959,
            Title = "Kaleidoscope",
            ReleaseDate = new DateOnly(2024, 1, 1),
            MinimumAge = 12
        }
    };

    public Task<IEnumerable<StreamingShow>> GetAll()
    {
        return Task.FromResult(s_shows.AsEnumerable());
    }
}
