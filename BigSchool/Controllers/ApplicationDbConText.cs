using BigSchool.Models;
using System;
using System.Data.Entity;

namespace BigSchool.Controllers
{
    internal class ApplicationDbConText
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public static implicit operator ApplicationDbConText(ApplicationDbContext v)
        {
            throw new NotImplementedException();
        }
    }
}