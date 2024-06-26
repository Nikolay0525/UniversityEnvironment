﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.MtoMTables;

namespace UniversityEnvironment.Data.Model.Tables
{
    public sealed class QuestionAnswer : EnvironmentObject
    {
        public string? AnswerText { get; set; }
        public Guid TestQuestionId { get; set; }
        public TestQuestion? Question { get; set; }
        public List<QuestionAnswerStudent>? QuestionAnswersStudents { get; set; }
    }
}
