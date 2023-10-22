﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InterfaceRepository
{
    public interface IIssueRepository:IGenericRepository<Issue>
    {
        Task<List<Issue>> GetAllIssue();
    }
}