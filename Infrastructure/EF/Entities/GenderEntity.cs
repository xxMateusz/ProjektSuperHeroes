using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("gender")]
    public class GenderEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("gender")]
        public string GenderName { get; set; }
    }
}
