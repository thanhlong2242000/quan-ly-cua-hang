using BanHang.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BanHang.Domain.Commands
{
    public class LayThongTin_ProductCommand
    {
        public Product product { get; set; }
        public LayThongTin_ProductCommand(Product _product)
        {
            product = _product;
        }
    }
}
