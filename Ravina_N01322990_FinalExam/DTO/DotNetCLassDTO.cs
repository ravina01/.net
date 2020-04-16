using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO

{
    public class DotNetClassDTO
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public InstructorDTO Address { get; set; }
        public List<InstructorDTO> instructors { get; set; }
    }
    
}
