using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Test_Lists { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Level> Levels { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<forgotPasswordView> forgotPassword { get; set; }

        public DbSet<User_ReportView> user_report { get; set; }
        public DbSet<Security_Question> Security_Questions { get; set; }
        public DbSet<SearchUser> SearchUsers { get; set; }

        public DbSet<SearchQuestion> SearchQuestions { get; set; }
    }
}
