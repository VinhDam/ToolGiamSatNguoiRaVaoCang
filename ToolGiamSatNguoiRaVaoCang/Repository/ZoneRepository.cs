using Microsoft.EntityFrameworkCore;
using ToolGiamSatNguoiRaVaoCang.Data;
using ToolGiamSatNguoiRaVaoCang.Models;
using ToolGiamSatNguoiRaVaoCang.Repository.IRepository;

namespace ToolGiamSatNguoiRaVaoCang.Repository
{
    public class ZoneRepository : IZoneRepository
    {
        private readonly ApplicationDbContext _db;

        public ZoneRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Zone> CreateAsync(Zone obj)
        {
            obj.CreateDate = DateTime.Now;
            obj.UpdateDate = obj.CreateDate;
            await _db.Zone.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Zone.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Zone.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Zone>> GetAllAsync()
        {
            return await _db.Zone.ToListAsync();
        }

        public async Task<Zone> GetAsync(int id)
        {
            var obj = await _db.Zone.FirstOrDefaultAsync(u => u.Id == id);
            if (obj == null)
            {
                return new Zone();
            }
            return obj;
        }

        public async Task<Zone> UpdateAsync(Zone obj)
        {
            var objFromDb = await _db.Zone.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Code = obj.Code;
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.ZoneTypeId = obj.ZoneTypeId;
                objFromDb.UpdateDate = obj.UpdateDate;
                _db.Zone.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }
    }
}
