using VecozoApi;

var builder = WebApplication.CreateBuilder(args);

// registratie
builder.Services
    .AddGraphQLServer()
    .ModifyRequestOptions(options => options.IncludeExceptionDetails = builder.Environment.IsDevelopment())
    //.AddDiagnosticEventListener()
    .AddQueryType<QueryType>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGraphQL();

app.Run();
