using CleanArch.Domain;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
