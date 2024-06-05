using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Takip_Programı.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]


        public string Phone { get; set; }

        public string Duty { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Leave Leaves { get; set; }
        public virtual Salary Salaries { get; set; }
    }
}
