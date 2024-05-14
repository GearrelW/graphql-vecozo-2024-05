using HotChocolate.Fetching;
using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi.DataLoaders;

public class EpisodeBatchDataLoader : BatchDataLoader<int, Episode>
{
    private readonly EpisodeRepository _episodeRepo;

    public EpisodeBatchDataLoader(
        EpisodeRepository episodeRepo,
        IBatchScheduler batchScheduler,
        DataLoaderOptions? options = null)
        : base(batchScheduler, options)
    {
        _episodeRepo = episodeRepo;
    }

    protected async override Task<IReadOnlyDictionary<int, Episode>> LoadBatchAsync(IReadOnlyList<int> keys, CancellationToken cancellationToken)
    {
        var episodes = await _episodeRepo.GetEpisodesForKeys(keys);
        return episodes.ToDictionary(x => x.Id);
    }
}
