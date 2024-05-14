namespace VecozoApi.Entities;

public interface IShow
{
    int Id { get; }

    string Title { get; }

    DateOnly ReleaseDate { get; }

    IEnumerable<Episode> Episodes { get; }
}
