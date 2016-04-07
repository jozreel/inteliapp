using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace inteliapp.DAL
{
    public class IntelicoContex:DbContext
    {
        public IntelicoContex():base("inteliappconn")
        {

        }
        public DbSet<Models.Equipment> Equipment { get; set;}
        public DbSet<Models.Field> Fields { get; set; }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.EquipmentCollection> EquipmentCollection { get; set; }

    }
}