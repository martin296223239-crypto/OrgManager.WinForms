using Microsoft.EntityFrameworkCore;
using OrgManager.WinForms.Data;
using OrgManager.WinForms.Domain;


namespace OrgManager.WinForms.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _db;
        public EmployeeService(AppDbContext db) => _db = db;


        public async Task<List<Employee>> GetAllAsync() =>
        await _db.Employees.OrderBy(e => e.LastName).ThenBy(e => e.FirstName).ToListAsync();


        public async Task<Employee?> GetAsync(int id) => await _db.Employees.FindAsync(id);


        public async Task<Employee> CreateAsync(Employee e)
        {
            Validate(e);
            _db.Employees.Add(e);
            await _db.SaveChangesAsync();
            return e;
        }


        public async Task UpdateAsync(Employee e)
        {
            Validate(e);
            _db.Employees.Update(e);
            await _db.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var entity = await _db.Employees.FindAsync(id);
            if (entity == null) return;
            _db.Employees.Remove(entity);
            await _db.SaveChangesAsync();
        }


        private static void Validate(Employee e)
        {
            if (string.IsNullOrWhiteSpace(e.FirstName))
                throw new ValidationException("Meno je povinné.");
            if (string.IsNullOrWhiteSpace(e.LastName))
                throw new ValidationException("Priezvisko je povinné.");
            if (!string.IsNullOrWhiteSpace(e.Email) && !e.Email.Contains('@'))
                throw new ValidationException("E-mail má nesprávny formát.");
            if (!string.IsNullOrWhiteSpace(e.Phone))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(e.Phone, @"^(?:\+421|0)\d{9}$"))
                    throw new ValidationException("Telefónne číslo musí byť vo formáte +421xxxxxxxxx alebo 09xxxxxxxx.");
            }
        }
    }
}