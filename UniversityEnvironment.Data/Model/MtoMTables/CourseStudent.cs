﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.Data.Model.MtoMTables
{
    public class CourseStudent : CourseUser
    {
        public Student? Student { get; set; }
        public Course? Course { get; set; }
    }
}
