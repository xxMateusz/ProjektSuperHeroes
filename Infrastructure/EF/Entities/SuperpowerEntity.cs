using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("superpower")]
    public class SuperpowerEntity
    {
        public string Id { get; set; }
        public string PowerName { get; set; }
    }
}
