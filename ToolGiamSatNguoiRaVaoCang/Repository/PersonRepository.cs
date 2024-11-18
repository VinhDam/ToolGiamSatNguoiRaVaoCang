﻿using Microsoft.EntityFrameworkCore;
using ToolGiamSatNguoiRaVaoCang.Data;
using ToolGiamSatNguoiRaVaoCang.Models;
using ToolGiamSatNguoiRaVaoCang.Repository.IRepository;

namespace ToolGiamSatNguoiRaVaoCang.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _db;

        public PersonRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<Person> CreateAsync(Person obj)
        {
            obj.CreateDate = DateTime.Now;
            obj.UpdateDate = DateTime.Now;
            await _db.Person.AddAsync(obj);
            await _db.SaveChangesAsync();
            return obj;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var obj = await _db.Person.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Person.Remove(obj);
                return (await _db.SaveChangesAsync()) > 0;
            }
            return false;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _db.Person.ToListAsync();
        }

        public async Task<Person> GetAsync(int id)
        {
            var obj = await _db.Person.FirstOrDefaultAsync(u => u.Id == id);
            if (obj == null)
            {
                return new Person();
            }
            return obj;
        }

        public async Task<Person> UpdateAsync(Person obj)
        {
            var objFromDb = await _db.Person.FirstOrDefaultAsync(u => u.Id == obj.Id);
            if (objFromDb is not null)
            {
                objFromDb.Code = obj.Code;
                objFromDb.Name = obj.Name;
                objFromDb.Description = obj.Description;
                objFromDb.UpdateDate = obj.UpdateDate;
                _db.Person.Update(objFromDb);
                await _db.SaveChangesAsync();
                return objFromDb;
            }
            return obj;
        }
    }
}