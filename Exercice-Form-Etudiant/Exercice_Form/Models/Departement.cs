﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Exercice_Form.Models
{
    public class Departement
    {
        public int DepartementId { get; set; }

        [StringLength(50)]
        public string Nom { get; set; }

        public double Budget { get; set; }

        public List<Employe> Employes { get; set; }
    }
}