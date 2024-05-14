using VecozoApi.DataLoaders;
using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi.Types;

public class TvShowType : ObjectType<TvShow>
{
    protected override void Configure(IObjectTypeDescriptor<TvShow> descriptor)
    {
        descriptor.Authorize();

        descriptor
            .Field(f => f.Episodes)
            .Type<NonNullType<ListType<NonNullType<EpisodeType>>>>()
            .Resolve(async ctx =>
            {
                var show = ctx.Parent<TvShow>();

                var dataLoader = ctx.DataLoader<EpisodeBatchDataLoader>();
                var episodes = await dataLoader.LoadAsync(new int[] { show.Id });

                //var episodeRepo = ctx.Service<EpisodeRepository>();
                //var eps = await episodeRepo.GetAllForShow(show.Id);
                return episodes;
            });
    }
}
