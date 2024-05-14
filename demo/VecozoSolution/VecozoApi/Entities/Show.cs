using VecozoApi.Repositories;

namespace VecozoApi.Entities;

public class TvShow : IShow
{
    public int Id { get; set; }

    public string Title { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public IEnumerable<Episode> Episodes { get; set; }

    public bool IsLive { get; set; }

    //public async Task<IEnumerable<Episode>> Episodes([Service] EpisodeRepository episoderepository)
    //{
    //    return await episoderepository.GetAllForShow(Id);
    //}

    // Int String Bool ID
}
