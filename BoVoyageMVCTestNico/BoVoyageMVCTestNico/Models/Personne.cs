using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Models
{
    public class Personne : BaseModel
    {
        
        public string Civilite { get; set; }

        [Required(ErrorMessage = "Le Nom est obligatoire")]
        [Display(Name = "Nom")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le Nom doit contenir entre {2} et {1} caractères")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le Prénom est obligatoire")]
        [Display(Name = "Prénom")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le Nom doit contenir entre {2} et {1} caractères")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "L'Adresse est obligatoire")]
        [Display(Name = "Adresse")]
        [StringLength(250, MinimumLength = 2, ErrorMessage = "Le Nom doit contenir entre {2} et {1} caractères")]
        public string Adresse { get; set; }

        [Required(ErrorMessage = "Le numéro de téléphone est obligatoire")]
        [Display(Name = "Téléphone")]
        public string Telephone { get; set; }

        [Required(ErrorMessage = "La date de naissance est obligatoire")]
        [Display(Name = "Date de Naissance")]
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
    }
}