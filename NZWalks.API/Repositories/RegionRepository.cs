using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NzwalksDBContext nzwalksDBContext;

        public RegionRepository(NzwalksDBContext nzwalksDBContext)
        {
            this.nzwalksDBContext = nzwalksDBContext;
        }


        public async Task <IEnumerable<Region>> GetAllAsync()
        {
            return await nzwalksDBContext.Regions.ToListAsync();
        }
    }
}
