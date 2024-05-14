using HotChocolate;
using HotChocolate.Execution;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Snapshooter.MSTest;
using VecozoApi.Entities;
using VecozoApi.Repositories;

namespace VecozoApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task SchemaDoesNotChangeTest()
        {
            var schema = await new ServiceCollection()
                .AddGraphQL()
                .AddFiltering()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .BuildSchemaAsync();

            schema.ToString().MatchSnapshot();
        }

        [TestMethod]
        public async Task StaticPropertyTest()
        {
            var result = await new ServiceCollection()
                .AddGraphQL()
                .AddFiltering()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .ExecuteRequestAsync("{ andertekstje }");

            result.ToJson().MatchSnapshot();
        }

        [TestMethod]
        public async Task PropertyWithMockingTest()
        {
            // Moq
            // NSubstitute
            // FakeItEasy

            var mockShowRepo = new Mock<IShowRepository>();
            mockShowRepo.Setup(x => x.GetAll()).ReturnsAsync(new List<Show>
            {
                new() { Title = "test1" },
                new() { Title = "test2" }
            });

            var result = await new ServiceCollection()
                .AddGraphQL()
                .AddFiltering()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .Services
                .AddTransient(_ => mockShowRepo.Object)
                .BuildServiceProvider()
                .ExecuteRequestAsync("{ shows { title } }");

            result.ToJson().MatchSnapshot();
        }
    }
}