﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ErpCore.Entities.InventorySetup
{
    public class PackageType : BaseClass
    {
        public PackageType()
        {
        }

        [Key]
        public long PackageTypeId { get; set; }
        public string Name { get; set; } //Carton or tray or box
        public string Description { get; set; }

    }
}