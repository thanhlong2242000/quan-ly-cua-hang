using BanHang.Appication.Interfaces;
using BanHang.Appication.Models;
using Microsoft.AspNetCore.Mvc;

using System;

namespace QUAN_LY_BAN_HANG.Controller
{
    public class BanHangController : ControllerBase
    {
        private readonly IBanHangServices _BanHangServices;

        [HttpGet]
        [Route("LayThongTin_Product")]
        public ResponseData LayThongTin_Product()
        {
            try
            {
                var ab = _BanHangServices.LayThongTin_Product();
                return new ResponseData(true, "200", ab);
            }
            catch (Exception ex)
            {
                return new ResponseData(false, ex.Message, null);
            }
        }
    }
}
