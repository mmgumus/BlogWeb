using Blog.Service.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Areas.Admin.Controller
{
    [Area("Admin")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public async Task<IActionResult> Index()
        {
            var articles = await _articleService.GetAllArticleAsync();
            return View(articles);
        }
    }
}
