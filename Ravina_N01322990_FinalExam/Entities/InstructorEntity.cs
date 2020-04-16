using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Instructor")]
    public class InstructorEntity : IEntity
    {
        public Guid Id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }

    }
}

