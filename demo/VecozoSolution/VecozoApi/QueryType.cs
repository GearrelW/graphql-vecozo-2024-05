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

        //descriptor
        //    .Field(f => f.Tekstje)
        //    .Type<NonNullType<ListType<NonNullType<StringType>>>>();
    }
}
