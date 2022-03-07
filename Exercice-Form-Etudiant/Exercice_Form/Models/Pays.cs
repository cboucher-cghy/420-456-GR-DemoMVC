using System.Collections.Generic;

namespace Exercice_Form.Models
{
    public class Pays
    {
        public int PaysId { get; set; }
        public string Nom { get; set; }
        public int Superficie { get; set; }
        public List<Employe> Employes { get; set; }
    }
}