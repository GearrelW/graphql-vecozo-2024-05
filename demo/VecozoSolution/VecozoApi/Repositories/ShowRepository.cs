using VecozoApi.Entities;

namespace VecozoApi.Repositories;

public class ShowRepository
{
    private static List<Show> s_shows = new()
    {
        new()
        {
            Id = 2,
            Title = "The Gentlemen",
            ReleaseDate = new DateOnly(2024, 1, 1)
        },
        new()
        {
            Id = 4,
            Title = "Debiteuren crediteuren",
            ReleaseDate = new DateOnly(1995, 1, 1)
        },
        new()
        {
            Id = 8,
            Title = "Domino D-Day",
            ReleaseDate = new DateOnly(2003, 1, 1)
        }
    };

    public Task<IEnumerable<Show>> GetAll()
    {
        return Task.FromResult(s_shows.AsEnumerable());
    }

    public Task<Show> Get(int id)
    {
        return Task.FromResult(s_shows.Single(x => x.Id == id));
    }

    public Task<Show?> Find(string partOfTitle, int releaseYear)
    {
        return Task.FromResult(s_shows.SingleOrDefault(x => x.Title.Contains(partOfTitle) && x.ReleaseDate.Year == releaseYear));
    }
}
