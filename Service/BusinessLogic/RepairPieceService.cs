using Model;
using Repositories.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.BusinessLogic
{
   public class RepairPieceService : BaseService<RepairPiece, int>, IRepairPieceService
    {
        private readonly IRepairPieceRepository _repairPieceRepository;
        public RepairPieceService(IRepairPieceRepository repairPieceRepository) : base(repairPieceRepository)
        {
            _repairPieceRepository = repairPieceRepository;
        }

          public IList<RepairPiece> GetAllRepairPieces()
        {
            return _repairPieceRepository.GetAllRepairPieces();
        }
    }
}
