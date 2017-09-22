using System.Diagnostics;
using System.Threading.Tasks;
using GenericRepository.Data;
using Microsoft.AspNetCore.Mvc;
using GenericRepository.Models;

namespace GenericRepository.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _repository;

        public HomeController(ICategoryRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<IActionResult> Index()
        {
            
            var category = new Category
            {
                Description = "first category - very cool description",
                Name = "First category"
            };
            await _repository.Create(category);

            var coolestCategory = await _repository.GetCoolestCategory();
            
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
