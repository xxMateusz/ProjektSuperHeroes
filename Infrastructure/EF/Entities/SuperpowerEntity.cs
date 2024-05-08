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
        [Column("id")]
        public string Id { get; set; }

        [Column("power_name")]
        public string PowerName { get; set; }

        public List<SuperheroEntity> Superheroes { get; set; } = new List<SuperheroEntity>();
    }
}
