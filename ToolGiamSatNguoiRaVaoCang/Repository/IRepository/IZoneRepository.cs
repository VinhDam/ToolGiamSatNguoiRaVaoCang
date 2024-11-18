using ToolGiamSatNguoiRaVaoCang.Models;

namespace ToolGiamSatNguoiRaVaoCang.Repository.IRepository
{
    public interface IZoneRepository
    {
        public Task<Zone> CreateAsync(Zone obj);
        public Task<Zone> UpdateAsync(Zone obj);
        public Task<bool> DeleteAsync(int id);
        public Task<Zone> GetAsync(int id);
        public Task<IEnumerable<Zone>> GetAllAsync();
    }
}
