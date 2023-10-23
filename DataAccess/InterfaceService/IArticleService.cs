﻿using Application.ViewModels.ArticleViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InterfaceService
{
    public interface IArticleService
    {
        Task<IEnumerable<ArticleResponse>> GetAll();
    }
}
