using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi;

public class Query
{
    public string Tekstje { get; set; }

    //public Show FavoriteShow => throw new NotImplementedException("ga weg");

    public TvShow FavoriteShow => new()
    {
        Id = 4,
        Title = "Debiteuren crediteuren",
        ReleaseDate = new DateOnly(1995, 1, 1)
    };

    public IEnumerable<object> Shows { get; set; }

    public TvShow GetShowById { get; set; }

    public TvShow? FindShowByTitleAndReleaseYear { get; set; }

    //public Show GetShowById2(int id, [Service] )
    //{

    //}

    //public async Task<IEnumerable<Show>> Shows([Service] IShowRepository showRepository)
    //{
    //    return await showRepository.GetAll();
    //}
}
