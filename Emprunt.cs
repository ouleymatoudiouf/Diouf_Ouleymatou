using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diouf_Ouleymatou
{
    internal class Emprunt
    {
        public int Id { get; set; }
        public int Id_Voiture { get; set; }
        public int Id_Client { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }

        public List<Voiture> Voiture { get; set; }
        public List<Client> Clients { get; set; }
    }

}
   

