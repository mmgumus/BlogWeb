using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Data.IUnitOfWork;
using Blog.Data.UnitOfWorks;


namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        public ArticleService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Article>> GetAllAsync()
        {
            return await unitOfWork.GetRepository<Article>().GetAllAsync();
        }
    }
}

