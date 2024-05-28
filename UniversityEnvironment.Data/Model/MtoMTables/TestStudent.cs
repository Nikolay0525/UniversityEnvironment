using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityEnvironment.Data.Model.Tables;

namespace UniversityEnvironment.Data.Model.MtoMTables
{
    public class TestStudent
    {
        private int _mark = 0;
        public int Mark
        {
            get => _mark;

            set
            {

                if (value != 0 && (value < 2 || value > 5))
                {
                    throw new ArgumentException("Bad mark. Mark must be: 0 ,2, 3, 4 or 5.");
                }
                _mark = value;
            }
        }
        public Guid StudentId { get; set; }
        public Guid TestId { get; set; }
        public Student? Student { get; set; }
        public Test? Test { get; set; }
    }
}
