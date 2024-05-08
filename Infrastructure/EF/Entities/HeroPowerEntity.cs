using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("hero_power")]
    public class HeroPowerEntity
    {
        [Column("hero_id")]
        public int HeroId { get; set; }

        [Column("power_id")]
        public int PowerId { get; set; }

        public SuperheroEntity Hero { get; set; }
        public HeroPowerEntity Power { get; set; }
    }
}
