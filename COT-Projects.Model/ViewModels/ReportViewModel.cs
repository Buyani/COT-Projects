using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace COT_Projects.Model.ViewModels
{
    public class ReportViewModel
    {
        public int Id { get; set; }
        public int Short { get; set; }
        public int Long { get; set; }
        public int ChangeShort { get; set; }
        public int ChangeLong { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateCreated { get; set; }
        public int ShortPercent { get; set; }
        public int LongPercent { get; set; }
        public int CurrencyId { get; set; }
        public int Netpositions { get; set; }
    }
}
