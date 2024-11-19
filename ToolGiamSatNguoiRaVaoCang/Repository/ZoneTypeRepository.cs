using Microsoft.EntityFrameworkCore;
using ToolGiamSatNguoiRaVaoCang.Data;
using ToolGiamSatNguoiRaVaoCang.Models;
using ToolGiamSatNguoiRaVaoCang.Repository.IRepository;

namespace ToolGiamSatNguoiRaVaoCang.Repository
{
    public class ZoneTypeRepository : IZoneTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public ZoneTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<ZoneType> CreateAsync(ZoneType obj)
        {
            obj.CreateDate = DateTime.Now;
            obj.UpdateDate = obj.CreateDate;
            await _db.ZoneType.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.ZoneType.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.ZoneType.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<ZoneType>> GetAllAsync()
        {
            return await _db.ZoneType.ToListAsync();
        }

        public async Task<ZoneType> GetAsync(int id)
        {
            var obj = await _db.ZoneType.FirstOrDefaultAsync(u => u.Id == id);
            if (obj == null)
            {
                return new ZoneType();
            }
            return obj;
        }

        public async Task<ZoneType> UpdateAsync(ZoneType obj)
        {
            var objFromDb = await _db.ZoneType.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Code = obj.Code;
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.UpdateDate = obj.UpdateDate;
                _db.ZoneType.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }
    }
}
