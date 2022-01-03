using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barsovan_Narcisa_Proiect.Models
{
    public class Categorie
    {
        public int ID { get; set; }
        public string Nume_Catergorie { get; set; }
        public ICollection<Categorie_Produs_Make_up> Categorii_Produs_Make_up { get; set; }
    }
}
