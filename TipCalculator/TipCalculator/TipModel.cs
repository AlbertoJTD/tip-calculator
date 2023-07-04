using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator
{
    public class TipModel
    {
        public decimal Total { get; set; }
        public int PercentageTip { get; set; }
        public int NumberPeople { get; set; }
        public decimal TotalTip { get; set; }
        public decimal TotalBill { get; set; }
        public decimal TipPerPerson { get; set; }
        public decimal TotalPerPerson { get;set; }
    }
}
