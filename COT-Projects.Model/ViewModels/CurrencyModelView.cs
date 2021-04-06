using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Model.ViewModels
{
    public class CurrencyModelView
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public List<ReportViewModel> Reports { get; set; }
    }
}
