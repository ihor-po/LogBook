using MyLogbook.Abstractions;
using MyLogbook.Entities;
using System.Threading.Tasks;

namespace MyLogbook.Repositories
{
    public interface IGroupRepository:IDbRepository<Group>
    {
    }
}
