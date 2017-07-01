using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhysicalCountsHub.Client.Core.ServiceContracts
{
    public interface IProductDataSource
    {
        Task<Dictionary<ulong, string>>  GetMasterList ();
    }
}
