using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table(Name = "Worker")]
    public class Worker : IModel
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        public int BossId { get; set; }    

        public int SpecialityID { get; set; }

        public bool IsBoss { get; set; }
    }
}
