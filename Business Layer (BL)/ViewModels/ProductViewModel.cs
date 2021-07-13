﻿using Data_Access_Layer__DAL_;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer__BL_.ViewModels
{
    class ProductViewModel
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }
        public string description { get; set; }
        [Required]
        public int price { get; set; }
        public int? discount { get; set; }
        public string img { get; set; }

        [Required]
        public Category type { get; set; }
    }
}