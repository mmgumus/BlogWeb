using AutoMapper;
using Blog.Entity.Entities;
using Blog.Service.Services.Abstractions;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.ArticleDto;


namespace Blog.Service.Services.Concrete
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = _mapper.Map<List<ArticleDto>>(articles);
            return map;
        }
    }
}

