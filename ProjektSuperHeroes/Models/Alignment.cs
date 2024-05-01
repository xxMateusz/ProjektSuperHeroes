using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class Alignment : IIdentity<int>
    {
        public int Id { get; set; }
        public string AlignmentName { get; set; }
    }
}
