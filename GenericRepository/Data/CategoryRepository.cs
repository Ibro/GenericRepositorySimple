using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Data
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(CodingBlastDbContext dbContext)
        : base(dbContext)
        {
            
        }

        public async Task<Category> GetCoolestCategory()
        {
            return await GetAll()
                .OrderByDescending(c => c.Name)
                .FirstOrDefaultAsync();
        }
    }
}