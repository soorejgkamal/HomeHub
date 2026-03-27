using HomeHub.Models;

namespace HomeHub.Services;

public class MockDataService : IMockDataService
{
    public List<HouseholdTask> GetTasks()
    {
        return new List<HouseholdTask>
        {
            new() { Id = 1, Title = "Clean the kitchen",       DueDate = DateTime.Today,           IsDone = false },
            new() { Id = 2, Title = "Do the laundry",          DueDate = DateTime.Today.AddDays(1), IsDone = false },
            new() { Id = 3, Title = "Vacuum living room",      DueDate = DateTime.Today.AddDays(2), IsDone = true  },
            new() { Id = 4, Title = "Take out the trash",      DueDate = DateTime.Today.AddDays(1), IsDone = false },
            new() { Id = 5, Title = "Water the plants",        DueDate = DateTime.Today.AddDays(3), IsDone = false },
            new() { Id = 6, Title = "Grocery shopping",        DueDate = DateTime.Today.AddDays(4), IsDone = true  },
            new() { Id = 7, Title = "Fix leaky bathroom tap",  DueDate = DateTime.Today.AddDays(7), IsDone = false },
        };
    }

    public List<Bill> GetBills()
    {
        return new List<Bill>
        {
            new() { Id = 1, Name = "Electricity",   Amount = 120.50m,  DueDate = DateTime.Today.AddDays(5),  IsPaid = false },
            new() { Id = 2, Name = "Internet",      Amount = 59.99m,   DueDate = DateTime.Today.AddDays(8),  IsPaid = false },
            new() { Id = 3, Name = "Rent",          Amount = 1500.00m, DueDate = DateTime.Today.AddDays(10), IsPaid = true  },
            new() { Id = 4, Name = "Water",         Amount = 45.00m,   DueDate = DateTime.Today.AddDays(12), IsPaid = false },
            new() { Id = 5, Name = "Gas",           Amount = 75.25m,   DueDate = DateTime.Today.AddDays(15), IsPaid = false },
            new() { Id = 6, Name = "Phone",         Amount = 35.00m,   DueDate = DateTime.Today.AddDays(20), IsPaid = true  },
        };
    }

    public List<ShoppingItem> GetShoppingItems()
    {
        return new List<ShoppingItem>
        {
            new() { Id = 1, Name = "Milk",          Quantity = 2,  IsChecked = false },
            new() { Id = 2, Name = "Bread",         Quantity = 1,  IsChecked = false },
            new() { Id = 3, Name = "Eggs",          Quantity = 12, IsChecked = true  },
            new() { Id = 4, Name = "Apples",        Quantity = 6,  IsChecked = false },
            new() { Id = 5, Name = "Chicken",       Quantity = 1,  IsChecked = false },
            new() { Id = 6, Name = "Pasta",         Quantity = 2,  IsChecked = true  },
            new() { Id = 7, Name = "Dish soap",     Quantity = 1,  IsChecked = false },
            new() { Id = 8, Name = "Paper towels",  Quantity = 3,  IsChecked = false },
        };
    }
}
