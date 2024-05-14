using VecozoApi;
using VecozoApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// registratie
builder.Services.AddTransient<IShowRepository, ShowRepository>();
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
    .AddFiltering()
    .AddQueryType<QueryType>()
    .AddMutationType<MutationType>();
    //.AddSubscriptionType<>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
