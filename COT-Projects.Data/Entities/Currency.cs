﻿using System;
using System.Collections.Generic;
using System.Text;

namespace COT_Projects.Data.Entities
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Report> Reports { get; set; }
    }
}
