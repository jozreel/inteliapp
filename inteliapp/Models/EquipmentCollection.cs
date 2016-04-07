using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inteliapp.Models
{
    public class EquipmentCollection
    {
        public EquipmentCollection()
        {

        }
        public int EquipmentCollectionID{ get; set;}
        public int fieldID { get; set; }
        public string Value { get; set; }

        public Field Field { get; set; }
    }
}