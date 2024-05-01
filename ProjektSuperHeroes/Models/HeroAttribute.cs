using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class HeroAttribute
    {
        public Superhero Hero { get; set; }
        public Attribute Attribute { get; set; }
        public string AttributeValue { get; set; }
    }

}
