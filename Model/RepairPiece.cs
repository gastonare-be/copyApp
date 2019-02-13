using Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class RepairPiece : Entity<int>
    {
        string RepairName { get; set; }
        int RepairCost { get; set; }
        string PieceName { get; set; }
        int PieceCost { get; set; }
        int PieceQuantity { get; set; }
        int Total { get; set; }

        public static RepairPiece MapTo(IDataReader objDataReader)
        {
            var result = new RepairPiece();

            result.Id = int.Parse(objDataReader["RepairPieceId"].ToString());
            result.RepairName = objDataReader["RepairName"].ToString();
            result.RepairCost = int.Parse(objDataReader["RepairCost"].ToString());
            result.PieceName = objDataReader["PieceName"].ToString();
            result.PieceCost = int.Parse(objDataReader["PieceCost"].ToString());
            result.PieceQuantity = int.Parse(objDataReader["PieceQuantity"].ToString());
            result.Total = int.Parse(objDataReader["Total"].ToString());

            return result;
        }
    }
}
