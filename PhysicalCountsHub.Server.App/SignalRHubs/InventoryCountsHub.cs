using PocketHub.Client.Lib.UserInterfaces.Logging;
using PocketHub.Server.Lib.Configuration;
using PocketHub.Server.Lib.MainTabs.ConnectionsTab;
using PocketHub.Server.Lib.SignalRHubs;
using PocketHub.Server.Lib.UserAccounts;

namespace PhysicalCountsHub.Server.App.SignalRHubs
{
    public class InventoryCountsHub : SignalRHubBase
    {
        public InventoryCountsHub(ActivityLogVM activityLogVM, IUserAccountsRepo userAccountsRepo, CurrentClientsVM currentClientsVM, ServerSettings serverSettings) : base(activityLogVM, userAccountsRepo, currentClientsVM, serverSettings)
        {
        }
    }
}
