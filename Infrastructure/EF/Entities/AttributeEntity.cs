using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("attribute")]
    public class AttributeEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("attribute_name")]
        public string AttributeName { get; set; }
    }
}
