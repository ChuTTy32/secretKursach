using Libs;
using Model.Position;
using Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly ApplicationDbContext _context;

        public PositionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<PositionModel> GetAllPositions()
        {
            return _context.Positions.ToList();
        }

        public PositionModel GetPositionById(int id)
        {
            return _context.Positions.Find(id);
        }

        public void CreatePosition(PositionModel position)
        {
            _context.Positions.Add(position);
            _context.SaveChanges();
        }

        public void UpdatePosition(PositionModel position)
        {
            _context.Positions.Update(position);
            _context.SaveChanges();
        }

        public void DeletePosition(int id)
        {
            var position = _context.Positions.Find(id);
            if (position != null)
            {
                _context.Positions.Remove(position);
                _context.SaveChanges();
            }
        }
    }
}
