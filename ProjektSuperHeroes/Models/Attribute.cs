using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Attribute : IIdentity<int>
    {
        public int Id { get; set; }
        public string AttributeName { get; set; }
    }
}
