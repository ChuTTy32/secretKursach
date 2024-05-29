using Libs;
using Microsoft.EntityFrameworkCore;
using Model.Staff;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        private readonly ApplicationDbContext _context;

        public StaffRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StaffModel> GetAllStaff()
        {
            return _context.Staff.ToList();
        }

        public StaffModel GetStaffById(int id)
        {
            return _context.Staff.Find(id);
        }

        public void CreateStaff(StaffModel staff)
        {
            _context.Staff.Add(staff);
            _context.SaveChanges();
        }

        public void UpdateStaff(StaffModel staff)
        {
            _context.Staff.Update(staff);
            _context.SaveChanges();
        }

        public void DeleteStaff(int id)
        {
            var staff = _context.Staff.Find(id);
            if (staff != null)
            {
                _context.Staff.Remove(staff);
                _context.SaveChanges();
            }
        }
    }
}
