using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kurdish.Models
{
    public class Schools
    {
        //public Schools() => Teachers = new HashSet<SchoolTeacher>();

        public int SchoolId { get; set; }

        [StringLength(50)]
        public string SName { get; set; }

        public  ICollection<SchoolTeacher> SchoolTeacher { get; set; }
    }
}
