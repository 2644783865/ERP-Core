﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTrackerInfrastructure.ViewModels.Mappings
{
    public class UsercredentialsModel
    {
        [Required]
        public string Id { get; set; }
        public string NewPassword { get; set; }
    }
}
