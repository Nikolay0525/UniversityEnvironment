﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model
{
    public class CourseAdmin : CourseUser
    {
        public Admin? Admin {  get; set; }
        public Course? Course { get; set; }
    }
}
