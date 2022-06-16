using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositoies
{
    public class PlaceRepository : IPlaceRespository
    {
        private readonly ApplicationDbContext _dbContext;

        public PlaceRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Place> GetPlaceAsync(int id)
        {
            return await _dbContext.Places
                .Include(p => p.Category)
                .Include(p => p.Country)
                .FirstOrDefaultAsync(p => p.IdPlace == id);
        }

        public async Task<IReadOnlyList<Place>> GetPlacesAsync()
        {
            return await _dbContext.Places
                .Include(p => p.Category)
                .Include(p => p.Country)
                .ToListAsync();
        }
    }
}
