using VecozoApi.Repositories;

namespace VecozoApi.Entities;

public class Show : IShow
{
    public int Id { get; set; }

    public string Title { get; set; }

    public DateOnly ReleaseDate { get; set; }

    public IEnumerable<Episode> Episodes { get; set; }

    public bool IsLive { get; set; }

    //public async Task<IEnumerable<Episode>> Episodes([Service] EpisodeRepository episodeRepository)
    //{
    //    return await episodeRepository.GetAllForShow(Id);
    //}

    // Int String Bool ID
}
