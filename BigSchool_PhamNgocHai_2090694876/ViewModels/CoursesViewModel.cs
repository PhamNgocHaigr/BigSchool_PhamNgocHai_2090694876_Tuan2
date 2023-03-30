using BigSchool_PhamNgocHai_2090694876.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BigSchool_PhamNgocHai_2090694876.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }

    }
}