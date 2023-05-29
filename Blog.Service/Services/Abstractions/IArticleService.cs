using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Entity.Entities;

namespace Blog.Service.Services.Abstractions
{
    internal interface IArticleService
    {
        Task<List<Article>> GetAllArticleAsync();
    }
}
