namespace BanHang.Infrastructure.Repositories
{
    public class BaseRepository<T1, T2>
    {
        private BanHangDbContext context;

        public BaseRepository(BanHangDbContext context)
        {
            this.context = context;
        }
    }
}