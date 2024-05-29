using Libs;
using Model.CarInfo;
using Repos.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repos.Repositories
{
    public class CarInfoRepository : ICarInfoRepository
    {
        private readonly ApplicationDbContext _context;

        public CarInfoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<CarInfoModel> GetAllCars()
        {
            return _context.Cars.ToList();
        }

        public CarInfoModel GetCarById(int id)
        {
            return _context.Cars.Find(id);
        }

        public void CreateCar(CarInfoModel car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void UpdateCar(CarInfoModel car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            var car = _context.Cars.Find(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                _context.SaveChanges();
            }
        }
    }
}