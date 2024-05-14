using VecozoApi.Entities;
using VecozoApi.Entities.Inputs;
using VecozoApi.Repositories;
using VecozoApi.Types;
using VecozoApi.Types.InputTypes;

namespace VecozoApi;

public class MutationType : ObjectType
{
    protected override void Configure(IObjectTypeDescriptor descriptor)
    {
        descriptor
            .Field("addShow")
            .Argument("input", a => a.Type<AddShowInputType>())
            .Type<NonNullType<ShowUnionType>>()
            .Resolve(async ctx =>
            {
                var input = ctx.ArgumentValue<AddShowInput>("input");

                var showRepo = ctx.Service<IShowRepository>();
                var updatedShow = await showRepo.Add(new Show
                {
                    Title = input.Title,
                    ReleaseDate = input.ReleaseDate
                });
                return updatedShow;
            });
    }
}
