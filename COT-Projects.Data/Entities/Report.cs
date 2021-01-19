using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Data.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public int Short { get; set; }
        public int Long { get; set; }
        public int ChangeShort { get; set; }
        public int ChangeLong { get; set; }
        public DateTime DateCreated { get; set; }
        public int Netpositions { get; set; }
        public int ShortPercent { get; set; }
        public int LongPercent { get; set; }
    }
}
