using VecozoApi.Entities;

namespace VecozoApi.Repositories;

public interface IStreamingdienstRepository
{
    Task<IEnumerable<StreamingShow>> GetAll();
}
