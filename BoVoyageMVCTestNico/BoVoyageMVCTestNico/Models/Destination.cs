using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoVoyageMVCTestNico.Models
{
    public class Destination : BaseModel
    {
        [Required(ErrorMessage = "Le Continent est obligatoire")]
        [Display(Name = "Continent")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Continent { get; set; }

        [Required(ErrorMessage = "Le Pays est obligatoire")]
        [Display(Name = "Pays")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Pays { get; set; }

        [Required(ErrorMessage = "Le Region est obligatoire")]
        [Display(Name = "Région")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Le champ {0} doit contenir entre {2} et {1} caractères")]
        public string Region { get; set; }

        [AllowHtml]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
}