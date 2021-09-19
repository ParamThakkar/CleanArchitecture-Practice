using CleanArch.Domain;
using System.Collections.Generic;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> MyProperty { get; set; }
    }
}
