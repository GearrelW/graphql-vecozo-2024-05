using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi.Types;

public class ShowType : ObjectType<Show>
{
    protected override void Configure(IObjectTypeDescriptor<Show> descriptor)
    {
        descriptor
            .Field(f => f.Episodes)
            .Type<NonNullType<ListType<NonNullType<EpisodeType>>>>()
            .Resolve(async ctx =>
            {
                await Console.Out.WriteLineAsync("resolving!");
                var episodeRepository = ctx.Service<EpisodeRepository>()!;
                var show = ctx.Parent<Show>();
                return await episodeRepository.GetAllForShow(show.Id);
            });
    }
}
