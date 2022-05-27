﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Domain.Models
{
    public class User 
    {
        public int User_ID { get; set; }
        public string User_Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public int Phone { get; set; }
        public string Role { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
