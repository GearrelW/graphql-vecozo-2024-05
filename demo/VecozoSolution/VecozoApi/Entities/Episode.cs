using VecozoApi.Repositories;

namespace VecozoApi.Entities;

public class Episode
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int ShowId { get; set; }

    public async Task<Show> Show([Service] ShowRepository showRepository)
    {
        await Console.Out.WriteLineAsync("Hoi!");
        return await showRepository.Get(ShowId);
    }
}
