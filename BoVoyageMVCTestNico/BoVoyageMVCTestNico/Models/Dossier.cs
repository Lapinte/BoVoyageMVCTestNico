using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Models
{
    public class Dossier : BaseModel
    {
        [Required(ErrorMessage = "Le numéro de carte de crédit est obligatoire")]
        [Display(Name = "N° Carte de crédit :")]
        [DataType(DataType.CreditCard)]
        public string NumeroCarteBancaire { get; set; }

        public float PrixTotal { get; set; }

        [Display(Name = "Assurance Annulation :")]
        public bool Assurance { get; set; }

        public int VoyageID { get; set; }
        [ForeignKey("VoyageID")]
        public Voyage Voyage { get; set; }

        public int ClientID { get; set; }
        [ForeignKey("ClientID")]
        public Client Client { get; set; }
    }
}