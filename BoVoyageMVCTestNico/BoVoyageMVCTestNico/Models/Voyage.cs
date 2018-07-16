using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Models
{
    public class Voyage : BaseModel
    {
        [Required(ErrorMessage = "La date de départ est obligatoire")]
        [Display(Name = "Date de Départ :")]
        [DataType(DataType.Date)]
        public DateTime DateAller { get; set; }

        [Required(ErrorMessage = "La date de retour est obligatoire")]
        [Display(Name = "Date de Retour :")]
        [DataType(DataType.Date)]
        public DateTime DateRetour { get; set; }

        [Required(ErrorMessage = "Le nombre de places disponibles est obligatoire")]
        [Display(Name = "Places disponibles :")]
        public int PlacesDisponibles { get; set; }

        [Required(ErrorMessage = "Le tarif est obligatoire")]
        [Display(Name = "Tarif tout compris par personne :")]
        public float TarifToutCompris { get; set; }

        public int DestinationID { get; set; }
        [ForeignKey("DestinationID")]
        public Destination Destination { get; set; }

        public int AgenceID { get; set; }
        [ForeignKey("AgenceID")]
        public Agence Agence { get; set; }
    }
}