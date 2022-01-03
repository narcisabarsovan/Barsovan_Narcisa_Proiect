using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barsovan_Narcisa_Proiect.Models
{
    public class Furnizor
    {
        public int ID { get; set; }
        public string Nume_Furnizor { get; set; }
        public ICollection<Produs_Make_up> Produse_Make_up { get; set; }
    }
}
