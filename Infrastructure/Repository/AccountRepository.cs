﻿using Application.InterfaceRepository;
using Application.InterfaceService;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AccountRepository : GenericRepository<Account>, IAccountRepository
    {
        public AccountRepository(AppDbContext dbContext, IClaimService claimService, ICurrentTime currentTime) : base(dbContext, claimService, currentTime)
        {
        }
    }
}