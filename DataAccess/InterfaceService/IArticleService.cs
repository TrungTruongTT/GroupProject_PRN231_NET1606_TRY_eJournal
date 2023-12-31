
using Application.ViewModels.ArticleViewModels;
using BusinessObject.Enums;
using Microsoft.AspNetCore.Http;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InterfaceService
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleResponse>> GetAll(ArticleStatus? status);
        Task<string> AddArticleFile(IFormFile file, Guid id);
        Task<List<Article>> GetAllArticle();
        Task<Article> GetArticles(Guid id);
        Task<int> CreateArticle(Article article);
        Task<int> UpdateArticle(Article article);
        Task<int> DeleteArticle(Guid id);
        //search Article By Title Or AuthorName
        Task<List<Article>> SearchArticle(string value);
        Task SubmitArticle(Guid id);
    }
}
