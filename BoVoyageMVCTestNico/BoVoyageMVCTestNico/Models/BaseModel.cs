﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoVoyageMVCTestNico.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]

        public DateTime CreatedAt { get; set; }

        public bool Deleted { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}