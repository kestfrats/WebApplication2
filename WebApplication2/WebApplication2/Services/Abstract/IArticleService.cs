﻿

using WebApplication2.Areas.Blog.Model;

namespace WebApplication2.Services.Abstract
{
    public interface IArticleService
    {
        public void Create(ArticleVM model);
        public void Update(ArticleVM model);
        public void Delete(ArticleVM model);

        public List<ArticleVM> GetAll();
    }
}