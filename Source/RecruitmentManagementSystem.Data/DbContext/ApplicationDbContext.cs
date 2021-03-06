﻿using System.Data.Entity;
using System.Web.Configuration;
using Microsoft.AspNet.Identity.EntityFramework;
using RecruitmentManagementSystem.Model;

namespace RecruitmentManagementSystem.Data.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base(WebConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString, false)
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<QuestionCategory> QuestionCategories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
    }
}