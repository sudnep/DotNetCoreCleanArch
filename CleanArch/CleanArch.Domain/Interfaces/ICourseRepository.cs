using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models.Interfaces
{
    // course repository interface
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
