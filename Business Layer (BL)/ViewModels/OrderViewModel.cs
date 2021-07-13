using Data_Access_Layer__DAL_;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer__BL_.ViewModels
{
    class OrderViewModel
    {   //need to adding some validations
        public int Id { get; set; }

        [Required]
        public string date { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public int? discount { get; set; }
        public Category type { get; set; }
    }
}
