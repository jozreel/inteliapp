using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace inteliapp.DAL
{
    public class IntelicoInit:DropCreateDatabaseIfModelChanges<IntelicoContex>
    {
        protected override void Seed(IntelicoContex context)
        {
            var equip = new List<Models.Equipment>
            {
                new Models.Equipment {EquipmentDescription="Trackers for the entire Company", Name="Tracker"},
                new Models.Equipment {EquipmentDescription="Cameras For the familly", Name="Cameras"},
                 new Models.Equipment {EquipmentDescription="Phones for all a we", Name="Phones"},
                  new Models.Equipment {EquipmentDescription="Printers for you", Name="Printers"}
            };
            equip.ForEach(e => context.Equipment.Add(e));
            context.SaveChanges();
            var fields = new List<Models.Field>
            {
                new Models.Field {FieldName="Model", FieldType="text", Required=true, EquipmentID=1,FieldLabel="Tracker Model"},
                 new Models.Field {FieldName="Manufacturer", FieldType="text", Required=true, EquipmentID=2, FieldLabel="Camera Manu"},
                 new Models.Field {FieldName="Color", FieldType="text", Required=true, EquipmentID=1, FieldLabel="tracker color" },
                   new Models.Field {FieldName="camColor", FieldType="text", Required=true, EquipmentID=2, FieldLabel="camcolor" }
            };
            fields.ForEach(f => context.Fields.Add(f));
            context.SaveChanges();
            var eqcol = new List<Models.EquipmentCollection>
            {
                new Models.EquipmentCollection {fieldID=1, Value="This is just another one",},
                new Models.EquipmentCollection {fieldID=3, Value="This is just another two",},
            };
            eqcol.ForEach(c => context.EquipmentCollection.Add(c));
            context.SaveChanges();

        }
        
    }

}