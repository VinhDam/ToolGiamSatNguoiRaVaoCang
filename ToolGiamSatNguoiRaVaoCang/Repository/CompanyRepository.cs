using Microsoft.EntityFrameworkCore;
using ToolGiamSatNguoiRaVaoCang.Data;
using ToolGiamSatNguoiRaVaoCang.Models;
using ToolGiamSatNguoiRaVaoCang.Repository.IRepository;

namespace ToolGiamSatNguoiRaVaoCang.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Company> CreateAsync(Company obj)
        {
            obj.CreateDate = DateTime.Now;
            obj.UpdateDate = obj.CreateDate;
            await _db.Company.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Company.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Company.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _db.Company.Include(u=>u.Priority).ToListAsync();
        }

        public async Task<Company> GetAsync(int id)
        {
            var obj = await _db.Company.FirstOrDefaultAsync(u => u.Id == id);
            if (obj == null)
            {
                return new Company();
            }
            return obj;
        }

        public async Task<Company> UpdateAsync(Company obj)
        {
            var objFromDb = await _db.Company.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Code = obj.Code;
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.UpdateDate = obj.UpdateDate;
                _db.Company.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }
    }
}
