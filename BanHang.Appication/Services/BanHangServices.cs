using BanHang.Appication.Interfaces;
using BanHang.Domain.Interfaces;

namespace BanHang.Appication.Services
{
    public class BanHangServices : IBanHangServices
    {
        private readonly IProductRepository _productRepository;

        public BanHangServices(
            IProductRepository productRepository)
        {
            _productRepository = productRepository;

        }
        public object LayThongTin_Product()
        {
            var ds = _productRepository.LayThongTin_Product();
            return ds;
        }
    }
}
