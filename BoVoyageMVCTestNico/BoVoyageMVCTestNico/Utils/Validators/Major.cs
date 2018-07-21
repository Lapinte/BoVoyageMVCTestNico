﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Utils.Validators
{
    public class Major : ValidationAttribute

    {
        private readonly int years;

        public Major(int years)
        {
            this.years = years;
        }

        public override bool IsValid(object value)
        {
            if (value is DateTime)
            {
                DateTime dt = (DateTime)value;
                return dt.AddYears(this.years) <= DateTime.Now;
            }
            return false;
        }
    }
}