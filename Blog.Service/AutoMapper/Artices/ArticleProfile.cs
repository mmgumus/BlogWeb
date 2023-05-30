using AutoMapper;
using Blog.Entity.DTOs.ArticleDto;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Artices;

public class ArticleProfile : Profile
{
    public ArticleProfile()
    {
        CreateMap<ArticleDto,Article>().ReverseMap();
    }
}