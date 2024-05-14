using VecozoApi;
using VecozoApi.Repositories;
using VecozoApi.Types;

var builder = WebApplication.CreateBuilder(args);

// registratie
builder.Services.AddTransient<IShowRepository, ShowRepository>();
builder.Services.AddTransient<IStreamingdienstRepository, StreamingdienstRepository>();
builder.Services.AddTransient<EpisodeRepository>();

builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(options =>
    {
        options.IncludeExceptionDetails = builder.Environment.IsDevelopment();
        //options.Complexity.Enable = true;
        //options.Complexity.MaximumAllowed = 1500;
    })
    //.AddMaxExecutionDepthRule(10)
    //.AddDiagnosticEventListener()
    .AddType<StreamingShowType>()
    .AddType<TvShowType>()
    .AddFiltering()
    .AddQueryType<QueryType>()
    .AddMutationType<MutationType>();
    //.AddSubscriptionType<>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
