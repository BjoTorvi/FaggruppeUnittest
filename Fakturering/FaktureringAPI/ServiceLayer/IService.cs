using System.Threading.Tasks;
using FaktureringAPI.Entities;

namespace FaktureringAPI.ServiceLayer
{
    public interface IService
    {
        Task<Kunde> GetKunde(int id);
    }
}