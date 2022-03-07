using System;
using System.ComponentModel.DataAnnotations;

namespace Exercice_Form.Models
{
    public class Employe
    {
        public int EmployeId { get; set; }

        [Required]
        public string Nom { get; set; }

        [Range(18, 75)]
        public int Age { get; set; }

        public DateTime DateEmbauche { get; set; }

        public int Salaire { get; set; }

        public bool EstEnEmploi { get; set; }

        public int PaysId { get; set; }
        public Pays PaysOrigine { get; set; }

        public int DepartementId { get; set; }
        public Departement Departement { get; set; }
    }
}