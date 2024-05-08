using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityEnvironment.Data.Model.Tables
{
    public class TestMark : EnvironmentObject
    {
        private int _mark = 0;
        public int Mark
        {
            get => _mark;

            set
            {

                if (value < 2 && value != 0 || value > 5 && value != 0)
                {
                    throw new ArgumentException("Неприпустима оцінка. Оцінка повинна бути 2, 3, 4 або 5.");
                }
                _mark = value;
            }
        }
        public Test? Test { get; set; }
        public Guid StudentId { get; set; }
    }
}
