using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurdish.Models
{
    public class SchoolTeacher
    {
        public int TeacherId { get; set; }
        public Teachers Teachers { get; set; }
        public int SchoolId { get; set; }
        public Schools Schools { get; set; }

        [StringLength(20)]
        public string TeacherType { get; set; }
    }
}
