using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Snapshooter.Xunit;

namespace VecozoApi.xUnit
{
    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var schema = await new ServiceCollection()
                .AddGraphQL()
                .AddFiltering()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .BuildSchemaAsync();

            schema.ToString().MatchSnapshot();
        }
    }
}