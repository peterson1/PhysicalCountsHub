using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalCountsHub.Common.API.ServiceContracts
{
    public interface IProductDataSource
    {
        Task<Dictionary<ulong, string>> GetMasterList();
    }
}
