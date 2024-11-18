using ToolGiamSatNguoiRaVaoCang.Models;

namespace ToolGiamSatNguoiRaVaoCang.Repository.IRepository
{
    public interface IZoneTypeRepository
    {
        public Task<ZoneType> CreateAsync(ZoneType obj);
        public Task<ZoneType> UpdateAsync(ZoneType obj);
        public Task<bool> DeleteAsync(int id);
        public Task<ZoneType> GetAsync(int id);
        public Task<IEnumerable<ZoneType>> GetAllAsync();
    }
}
