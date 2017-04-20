using CSharpAppwithFSharpDataLayer.Models.Domain;
using FSharpDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpAppwithFSharpDataLayer.Repository
{
    public interface ITable_1Repository : IRepository<Table_1>
    {

    }

    public class Table_1Repository : FSharpDataLayer.Repository<Table_1>, ITable_1Repository
    {
        public Table_1Repository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }

    }
}