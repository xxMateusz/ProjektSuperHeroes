using ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [PrimaryKey (nameof(HeroId), nameof(AttributeId))]
    [Table("hero_attribute")]
    public class HeroAttributeEntity
    {
        [Column("hero_id")]
        public int? HeroId { get; set; }

        public SuperheroEntity? Hero { get; set; }

        [Column("attribute_id")]
        public int? AttributeId { get; set; }

        public AttributeEntity? Attribute { get; set; }

        [Column("attribute_value")]
        public string? AttributeValue { get; set; }
    }
}
