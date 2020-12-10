using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLNV.Models
{
    public partial class Possition
    {
        public Possition()
        {
            Employee = new HashSet<Employee>();
        }
        /// <summary>
        /// Khóa chính
        /// </summary>
        public int PossitionId { get; set; }
        /// <summary>
        /// Tên vị trí/Chức vụ
        /// </summary>
        public string PossitionName { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}
