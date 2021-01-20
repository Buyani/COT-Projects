﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace COT_Projects.Model.ViewModels
{
    public class ReportViewModel
    {
        [Required]
        [Display(Name = "Short Positions")]
        public int Short { get; set; }
        [Required]
        [Display(Name = "Long Positions")]
        public int Long { get; set; }
        [Required]
        [Display(Name = "Change Short")]
        public int ChangeShort { get; set; }
        [Required]
        [Display(Name = "Change Long")]
        public int ChangeLong { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Release Date")]
        public DateTime DateCreated { get; set; }
        [Required]
        [Display(Name = "Short %")]
        public int ShortPercent { get; set; }
        [Required]
        [Display(Name = "Long %")]
        public int LongPercent { get; set; }
    }
}
