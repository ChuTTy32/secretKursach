using Model.Staff;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Staff
{
    public class StaffPresenter
    {
        private readonly IStaffRepository _repository;

        public StaffPresenter(IStaffRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<StaffModel> GetAllStaff()
        {
            return _repository.GetAllStaff();
        }

        public StaffModel GetStaffById(int id)
        {
            return _repository.GetStaffById(id);
        }

        public void CreateStaff(StaffModel staff)
        {
            _repository.CreateStaff(staff);
        }

        public void UpdateStaff(StaffModel staff)
        {
            _repository.UpdateStaff(staff);
        }

        public void DeleteStaff(int id)
        {
            _repository.DeleteStaff(id);
        }
    }
}
