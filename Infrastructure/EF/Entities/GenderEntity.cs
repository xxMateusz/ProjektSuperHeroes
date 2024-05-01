using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    public class GenderEntity
    {
        public int Id { get; set; }
        public string Gender { get; set; }
    }
}
