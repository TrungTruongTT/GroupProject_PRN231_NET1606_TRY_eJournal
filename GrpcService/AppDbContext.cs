﻿using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrpcService
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RequestDetail> RequestDetails { get; set; }
        public DbSet<RequestReview> RequestReviews { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<AccountSpecialization> AccountSpecializations { get; set; }
        public DbSet<Issue> Issue { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
