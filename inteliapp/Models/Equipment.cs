using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inteliapp.Models
{
    public class Equipment
    {

        public Equipment()
        {
            this.Fields = new HashSet<Field>();
        }
        public string Name { get; set; }
        public int EquipmentID { get; set; }
        public string EquipmentDescription { get; set; }
        public virtual ICollection<Field> Fields { get; set; }
    }
}