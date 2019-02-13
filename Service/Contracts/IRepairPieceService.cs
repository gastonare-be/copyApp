using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
   public interface IRepairPieceService : IBaseService <RepairPiece, int>
    {
        IList<RepairPiece> GetAllRepairPieces();
    }
}
