using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFMVC.Models
{
    public class Subject
    {
        [Key]

        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public string SubjectTerm { get; set; }

        public int SubjectCredets { get; set; }
    }
}
