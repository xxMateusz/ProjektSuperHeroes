using ApplicationCore.Commons.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EF.Entities
{
    [Table("publisher")]
    public class PublisherEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("publisher_name")]
        public string PublisherName { get; set; }
    }
}
