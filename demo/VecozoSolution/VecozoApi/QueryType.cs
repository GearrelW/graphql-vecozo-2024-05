using VecozoApi.Entities;
using VecozoApi.Repositories;
using VecozoApi.Types;

namespace VecozoApi;

public class QueryType : ObjectType<Query>
{
    protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
    {

        //descriptor.BindFieldsExplicitly();

        descriptor
            .Field("andertekstje")
            .Type<NonNullType<StringType>>()
            .Resolve(ctx =>
            {
                return "hey nu vanuit resolve";
            });

        descriptor
            .Field(f => f.Shows)
            .Type<NonNullType<ListType<NonNullType<ShowType>>>>();
            //.Resolve(async ctx =>
            //{
            //    var showRepository = ctx.Service<ShowRepository>();
            //    return await showRepository.GetAll();
            //});

        //descriptor
        //    .Field(f => f.Tekstje)
        //    .Type<NonNullType<ListType<NonNullType<StringType>>>>();
    }
}
