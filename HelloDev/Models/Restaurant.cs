using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HelloDev.Models//1ere etape (Model)
{
    public class Restaurant
    {

        public int Id { get; set; }

        [Required]//champ obligatoire
        public string Nom { get; set; }

        [Required]//champ obligatoire
        [StringLength(15, ErrorMessage = "Mauvaise saisie numero",MinimumLength = 9)]
        public string Telephone { get; set; }

        public string Specialite { get; set; }

        public Restaurant()//constructeur par defaut indispensable
        {

        }
    }
}