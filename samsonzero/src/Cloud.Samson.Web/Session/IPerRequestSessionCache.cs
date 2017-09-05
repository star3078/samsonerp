using System.Threading.Tasks;
using Cloud.Samson.Sessions.Dto;

namespace Cloud.Samson.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
