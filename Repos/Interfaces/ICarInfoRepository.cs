using Model.CarInfo;
using System.Collections.Generic;

namespace Repos.Interfaces
{
    public interface ICarInfoRepository
    {
        IEnumerable<CarInfoModel> GetAllCars();
        CarInfoModel GetCarById(int id);
        void CreateCar(CarInfoModel car);
        void UpdateCar(CarInfoModel car);
        void DeleteCar(int id);
    }
}