﻿using Application.InterfaceService;
using Application.Utils;
using Application.ViewModels.UserViewModels;
using AutoMapper;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IJwtService jwtService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _jwtService = jwtService;
        }

        public async Task<string> Login(AuthenticationRequest request)
        {
            var users = await _unitOfWork.GetRepository<Account>().GetAllAsync(x => x.Email == request.Email && x.PasswordHash.Equals(EncryptionUtils.Encrypt(request.Password, x.PasswordSalt)));
            var user = users.FirstOrDefault();
            if (user == null)
            {
                throw new Exception("Invalid Email or Password");
            }
            var token = _jwtService.GenerateAuthenticatedCustomerToken(user.RoleId.ToString(), user.Email, user.Id.ToString());
            return token;
        }

        public async Task Register(RegistrationRequest request)
        {
            var users = await _unitOfWork.GetRepository<Account>().GetAllAsync(x => x.Email == request.Email);
            if(users != null && users.Any())
            {
                throw new Exception("This email has been registered before");
            }
            var user = _mapper.Map<Account>(request);
            await _unitOfWork.GetRepository<Account>().AddAsync(user);
            await _unitOfWork.SaveAsync();
        }
    }
}