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

    public async Task<IEnumerable<Show>> Shows([Service] ShowRepository showRepository)
    {
        return await showRepository.GetAll();
    }
}
