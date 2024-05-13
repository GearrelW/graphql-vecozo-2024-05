using VecozoApi.Entities;

namespace VecozoApi.Repositories;

public class EpisodeRepository
{
    private static List<Episode> s_episodes = new()
    {
        new()
        {
            Id = 4,
            Title = "Nieuwe hââkjes",
            ShowId = 4
        },
        new()
        {
            Id = 8,
            Title = "Europa ohne Grenzen",
            ShowId = 8
        },
        new()
        {
            Id = 15,
            Title = "Uit, goed voor u!",
            ShowId = 4
        },
        new()
        {
            Id = 15,
            Title = "Heerlijk Avondje",
            ShowId = 4
        },
        new()
        {
            Id = 15,
            Title = "Expressions 4 Millions",
            ShowId = 8
        }
    };

    public Task<IEnumerable<Episode>> GetAllForShow(int showId)
    {
        return Task.FromResult(s_episodes.Where(x => x.ShowId == showId).AsEnumerable());
    }
}
