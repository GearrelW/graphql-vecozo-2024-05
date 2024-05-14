using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi;

public class Query
{
    public string Tekstje { get; set; }

    //public Show FavoriteShow => throw new NotImplementedException("ga weg");

    public Show FavoriteShow => new()
    {
        Id = 4,
        Title = "Debiteuren crediteuren",
        ReleaseDate = new DateOnly(1995, 1, 1)
    };

    public IEnumerable<Show> Shows { get; set; }

    public Show GetShowById { get; set; }

    public Show? FindShowByTitleAndReleaseYear { get; set; }

    //public Show GetShowById2(int id, [Service] )
    //{

    //}

    //public async Task<IEnumerable<Show>> Shows([Service] IShowRepository showRepository)
    //{
    //    return await showRepository.GetAll();
    //}
}
