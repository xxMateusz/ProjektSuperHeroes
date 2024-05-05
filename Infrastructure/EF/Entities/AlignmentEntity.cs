using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("alignment")]
    public class AlignmentEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("alignment")]
        public string AlignmentName { get; set; }
    }
}
