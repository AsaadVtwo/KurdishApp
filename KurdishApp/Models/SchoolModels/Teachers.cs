using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurdish.Models
{
    public class Teachers
    {
        //public Teachers() => Schools = new HashSet<SchoolTeacher>();
        public int TeacherId { get; set; }

        [StringLength(50)]
        public string TName { get; set; }

        public  ICollection<SchoolTeacher> SchoolTeacher { get; set; }
    }
}
