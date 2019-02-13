using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Model;
using Service;
using Service.Contracts;
using WebApplication2.Mapping;

namespace WebApplication2.Controllers
{
    [Route("api/RepairPiece")]
    [ApiController]
    public class RepairPieceController
    {
        private readonly IRepairPieceService _repairPieceService;
        private readonly IObjMapper _objMapper;

        public RepairPieceController(IRepairPieceService repairPieceService)
        {
            _repairPieceService = repairPieceService;
        }

        [HttpGet]
        [Route("All")]
        public IList<RepairPiece> GetAll()
        {
            var list = _repairPieceService.GetAllRepairPieces();
            return list.ToList();
        }

    }
}
