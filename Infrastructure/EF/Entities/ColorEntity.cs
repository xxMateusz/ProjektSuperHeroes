using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("colour")]
    public class ColorEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("colour")]
        public string ColorName { get; set; }
    }
}
