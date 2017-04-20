using CSharpAppwithFSharpDataLayer.Models.Domain;
using CSharpAppwithFSharpDataLayer.Repository;
using FSharpDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpAppwithFSharpDatalayer.Controllers
{
    public class HomeController : Controller
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IRepository<Table_1> _table1;
        readonly ITable_1Repository _uowTable;
        public HomeController(IUnitOfWork unitOfWork, IRepository<Table_1> table1, ITable_1Repository uowTable)
        {
            _unitOfWork = unitOfWork;
            _table1 = table1;
            _uowTable = uowTable;
        }
        public ActionResult Index()
        {
            var data = _uowTable.GetAll.ToList();
            var user = new Table_1 { Name = "User" + data.Count };
            user = _uowTable.Add(user);
            var result = _unitOfWork.Commit;
            return View();
        }
    }
}