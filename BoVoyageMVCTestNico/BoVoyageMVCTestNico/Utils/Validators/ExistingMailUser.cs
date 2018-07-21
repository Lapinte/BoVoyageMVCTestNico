using BoVoyageMVCTestNico.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Utils.Validators
{
    public class ExistingMailUser : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            using (BoVoyageMVCTestNicoDbContext db = new BoVoyageMVCTestNicoDbContext())
            {
                return !db.Clients.Any(x => x.Email == value.ToString());
            }
        }
    }
}