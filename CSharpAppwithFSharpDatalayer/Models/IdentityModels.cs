using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using CSharpAppwithFSharpDataLayer.Models.Domain;

namespace CSharpAppwithFSharpDataLayer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Table_1> Table1 { get; set; }
    }
}