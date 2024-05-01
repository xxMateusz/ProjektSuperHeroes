using ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [PrimaryKey (nameof(Hero), nameof(Attribute))]
    public class HeroAttributeEntity
    {
        public SuperheroEntity Hero { get; set; }
        public AttributeEntity Attribute { get; set; }
        public string AttributeValue { get; set; }
    }
}
