using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using educationPortal.Authorization.Roles;
using educationPortal.Authorization.Users;
using educationPortal.Comments;
using educationPortal.Courses;
using educationPortal.MultiTenancy;
using educationPortal.Tickets;

namespace educationPortal.EntityFrameworkCore
{
    public class educationPortalDbContext : AbpZeroDbContext<Tenant, Role, User, educationPortalDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public educationPortalDbContext(DbContextOptions<educationPortalDbContext> options)
            : base(options)
        {
        }

        #region Comment

        public DbSet<Comment> Comments { get; set; }

        #endregion
            
            
        #region Course 
        
        public DbSet<Course> Courses { get; set; }
        public DbSet<GivenCourse> GivenCourses { get; set; } 
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<FavoriteCourse> FavoriteCourses { get; set; }
        public DbSet<CourseAdvertisement> CourseAdvertisements { get; set; }
        
        #endregion

        #region Question

        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionResponse> QuestionResponses { get; set; }

        #endregion
        
    }
}
