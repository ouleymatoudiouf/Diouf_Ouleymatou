using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diouf_Ouleymatou
{
    internal class DBGES : DbContext

    {


        public DBGES() : base("DevConnection") { }

        public DbSet<Client> Client { get; set; }
        public DbSet<Voiture> Voiture { get; set; }
        public DbSet<Emprunt> Emprunt { get; set; }
    }
}

