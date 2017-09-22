using System.Threading.Tasks;

namespace GenericRepository.Data
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {
        Task<Category> GetCoolestCategory();
    }
}