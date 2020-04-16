using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("Class")]
    public class DotnetClassEntity : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<OrderEntity> instructor { get; set; }
    }
}
