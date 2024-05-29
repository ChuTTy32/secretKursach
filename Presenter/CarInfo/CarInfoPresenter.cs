using Libs;
using Model.CarInfo;
using Repos.Interfaces;
using System.Collections.Generic;

namespace Presenter.CarInfo
{
    public class CarInfoPresenter
    {
        private readonly ICarInfoRepository _repository;

        public CarInfoPresenter(ICarInfoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<CarInfoModel> GetAllCars()
        {
            return _repository.GetAllCars();
        }

        public CarInfoModel GetCarById(int id)
        {
            return _repository.GetCarById(id);
        }

        public void CreateCar(CarInfoModel car)
        {
            _repository.CreateCar(car);
        }

        public void UpdateCar(CarInfoModel car)
        {
            _repository.UpdateCar(car);
        }

        public void DeleteCar(int id)
        {
            _repository.DeleteCar(id);
        }
    }
}