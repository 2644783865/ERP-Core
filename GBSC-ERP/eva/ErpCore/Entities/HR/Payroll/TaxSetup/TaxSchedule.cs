using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ErpCore.Entities.HR.Payroll.TaxSetup
{
    public class TaxSchedule : BaseClass
    {
        [Key]
        public long TaxScheduleId { get; set; } 
        public string TaxType { get; set; }//PercentageAmount
        public double? From { get; set; }
        public double? To { get; set; }
        public double? Value { get; set; }
        public double? FixedValue { get; set; }
        public string ApplicabaleTo { get; set; }//Male, Female or Both

        public long? IncomeTaxRuleId { get; set; }
        public IncomeTaxRule IncomeTaxRule { get; set; }
    }
}
