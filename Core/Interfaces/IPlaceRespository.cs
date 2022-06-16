using Core.Entities;

namespace Core.Interfaces
{
    public interface IPlaceRespository
    {
        Task<Place> GetPlaceAsync(int id);
        Task<IReadOnlyList<Place>> GetPlacesAsync();
    }
}
