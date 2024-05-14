using VecozoApi.Entities;

namespace VecozoApi.Repositories
{
    public interface IShowRepository
    {
        Task<TvShow> Add(TvShow show);
        Task<TvShow?> Find(string partOfTitle, int releaseYear);
        Task<TvShow> Get(int id);
        Task<IEnumerable<TvShow>> GetAll();
    }
}