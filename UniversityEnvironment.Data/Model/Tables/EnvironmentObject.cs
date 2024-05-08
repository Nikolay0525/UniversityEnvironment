using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace UniversityEnvironment.Data.Model.Tables
{
    public abstract class EnvironmentObject
    {
        [Key]
        public Guid Id { get; set; }
        public EnvironmentObject()
        {
            Id = Guid.NewGuid();
        }
        public EnvironmentObject(Guid id)
        {
            Id = id;
        }
    }
}
