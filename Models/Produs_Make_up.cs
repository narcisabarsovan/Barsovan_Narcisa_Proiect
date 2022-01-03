using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Barsovan_Narcisa_Proiect.Models
{
    public class Produs_Make_up
    {
        public int ID { get; set; }
        public string Produs { get; set; }
        public string Marca { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        public DateTime Data_lansarii { get; set; }
        public int FurnizorID { get; set; }
        public Furnizor Furnizor { get; set; }
        public ICollection<Categorie_Produs_Make_up> Categorii_Produs_Make_up { get; set; }

    }
}
