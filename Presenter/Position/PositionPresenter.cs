using Model.Position;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Position
{
    public class PositionPresenter
    {
        private readonly IPositionRepository _repository;

        public PositionPresenter(IPositionRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<PositionModel> GetAllPositions()
        {
            return _repository.GetAllPositions();
        }

        public PositionModel GetPositionById(int id)
        {
            return _repository.GetPositionById(id);
        }

        public void CreatePosition(PositionModel position)
        {
            _repository.CreatePosition(position);
        }

        public void UpdatePosition(PositionModel position)
        {
            _repository.UpdatePosition(position);
        }

        public void DeletePosition(int id)
        {
            _repository.DeletePosition(id);
        }
    }
}
