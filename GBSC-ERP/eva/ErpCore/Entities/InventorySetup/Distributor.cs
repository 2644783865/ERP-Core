﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ErpCore.Entities.InventorySetup
{
    public class Distributor : BaseClass
    {
        public Distributor()
        {
        }

        [Key]
        public long DistributorId { get; set; }
        public string DRN { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string LandlineNumber { get; set; }
        public string MobilerNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Nature { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }

        public bool? HasTerritory { get; set; }

        public IEnumerable<Territory> Territories { get; set; }
    }
}
