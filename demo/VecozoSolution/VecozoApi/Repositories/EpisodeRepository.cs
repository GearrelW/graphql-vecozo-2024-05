using System.Linq;
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
            Id = 16,
            Title = "Heerlijk Avondje",
            ShowId = 4
        },
        new()
        {
            Id = 23,
            Title = "Expressions 4 Millions",
            ShowId = 8
        }
    };

    public Task<IEnumerable<Episode>> GetAllForShow(int showId)
    {
        Console.WriteLine("hallo vanuit episode repo");
        return Task.FromResult(s_episodes.Where(x => x.ShowId == showId).AsEnumerable());
    }

    public Task<IEnumerable<Episode>> GetEpisodesForKeys(IReadOnlyList<int> keys)
    {
        Console.WriteLine("hallo vanuit episode repo for keys");
        return Task.FromResult(s_episodes.Where(x => keys.Contains(x.ShowId)));
    }
}
