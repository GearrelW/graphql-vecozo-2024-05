using VecozoApi.Entities;

namespace VecozoApi.Repositories
{
    public interface IShowRepository
    {
        Task<Show> Add(Show show);
        Task<Show?> Find(string partOfTitle, int releaseYear);
        Task<Show> Get(int id);
        Task<IEnumerable<Show>> GetAll();
    }
}