using Model;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repository
{
   public class RepairPieceRepository : BaseRepository<RepairPiece, int> , IRepairPieceRepository
    {
      protected string GetAllStoreProcedureName => $"mg_{EntityName}_GetAll";

        public RepairPieceRepository(IDatabaseProviderFactory factory) : base(factory)
        {
            
        }

        public IList<RepairPiece> GetAllRepairPieces()
        {
            using (var command = Db.GetStoredProcCommand(GetAllStoreProcedureName))
            {
                return LoadCustomerPrinter(command);
            }
        }

        private IList<RepairPiece> LoadCustomerPrinter(DbCommand command)
        {
            var repairPieces = new List<RepairPiece>();

            using (var objDataReader = Db.ExecuteReader(command))
            {
                while (objDataReader.Read())
                {
                    var repairPiece = RepairPiece.MapTo(objDataReader);

                    repairPieces.Add(repairPiece);
                }

            }
            return repairPieces;
        }


    }
}
