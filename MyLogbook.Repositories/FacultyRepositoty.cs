using Microsoft.EntityFrameworkCore;
using MyLogbook.Abstractions;
using MyLogbook.AppContext;
using MyLogbook.Entities;
using System.Linq;

namespace MyLogbook.Repositories
{
    public class FacultyRepositoty : DbRepository<Faculty>, IFacultyRepository
    {
        public FacultyRepositoty(AppDbContext context) : base(context)
        {
        }
    }
}
