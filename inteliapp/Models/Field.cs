using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inteliapp.Models
{
    public class Field
    {
        public Field()
        {

          

        }

        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public int EquipmentID { get; set; }
        public bool Required { get; set; }
        public int FieldID { get; set; }
        public string FieldLabel { get; set; }
        public Equipment Equipment { get; set; }


    }
}