using HomeHub.Models;

namespace HomeHub.Services;

public interface IMockDataService
{
    List<HouseholdTask> GetTasks();
    List<Bill> GetBills();
    List<ShoppingItem> GetShoppingItems();
}
