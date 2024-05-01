using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    public class RaceEntity
    {
        public int Id { get; set; }
        public string RaceName { get; set; }
    }
}
