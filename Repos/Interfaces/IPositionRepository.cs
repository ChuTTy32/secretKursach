using Model.Position;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Interfaces
{
    public interface IPositionRepository
    {
        IEnumerable<PositionModel> GetAllPositions();
        PositionModel GetPositionById(int id);
        void CreatePosition(PositionModel position);
        void UpdatePosition(PositionModel position);
        void DeletePosition(int id);
    }
}
