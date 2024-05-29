using Model.Staff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Interfaces
{
    public interface IStaffRepository
    {
        IEnumerable<StaffModel> GetAllStaff();
        StaffModel GetStaffById(int id);
        void CreateStaff(StaffModel staff);
        void UpdateStaff(StaffModel staff);
        void DeleteStaff(int id);
    }
}
