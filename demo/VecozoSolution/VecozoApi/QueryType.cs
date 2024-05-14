using VecozoApi.Entities;
using VecozoApi.Entities.Inputs;
using VecozoApi.Repositories;
using VecozoApi.Types;
using VecozoApi.Types.InputTypes;

namespace VecozoApi;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {

        //descriptor.BindFieldsExplicitly();
        descriptor
            .Field(f => f.GetShowById)
            .Argument("id", a => a.Type<NonNullType<IntType>>())
            .Type<NonNullType<ShowType>>()
            .Resolve(async ctx =>
            {
                var id = ctx.ArgumentValue<int>("id");
                var showRepository = ctx.Service<IShowRepository>();
                return await showRepository.Get(id);
            });

        descriptor
            .Field(f => f.FindShowByTitleAndReleaseYear)
            .Argument("input", a => a.Type<NonNullType<FindShowByTitleAndReleaseYearInputType>>())
            .Type<ShowType>()
            .Resolve(async ctx =>
            {
                var input = ctx.ArgumentValue<FindShowByTitleAndReleaseYearInput>("input");
                var showRepository = ctx.Service<IShowRepository>();
                return await showRepository.Find(input.PartOfTitle, input.ReleaseYear);
            });

        descriptor
            .Field("andertekstje")
            .Type<NonNullType<StringType>>()
            .Resolve(ctx =>
            {
                return "hey nu vanuit resolve 2";
            });

        descriptor
            .Field(f => f.Shows)
            .Type<NonNullType<ListType<NonNullType<ShowType>>>>()
            .UseFiltering()
            .Resolve(async ctx =>
            {
                var showRepository = ctx.Service<IShowRepository>();
                return await showRepository.GetAll();
            });

        //descriptor
        //    .Field(f => f.Tekstje)
        //    .Type<NonNullType<ListType<NonNullType<StringType>>>>();
    }
}
