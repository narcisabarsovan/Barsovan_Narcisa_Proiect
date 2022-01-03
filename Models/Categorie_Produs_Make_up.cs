using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barsovan_Narcisa_Proiect.Models
{
    public class Categorie_Produs_Make_up
    {
        public int ID { get; set; }
        public int Produs_Make_upID { get; set; }
        public Produs_Make_up Produs_Make_Up { get; set; }
        public int CategorieID { get; set; }
        public Categorie Categorie { get; set; }
    }
}
