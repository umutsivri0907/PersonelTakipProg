using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Takip_Programı.Models
{
    public class Leave
    {
        public int Id { get; set; }
        [StringLength(50)]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Reason { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
