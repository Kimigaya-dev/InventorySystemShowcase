public class Program
{
    public static void Main()
    {
        // Create an inventory with 3 slots
        var inventory = new Inventory(3);

        // Add two health potions
        inventory.AddItem(new HealthPotion(50));
        inventory.AddItem(new HealthPotion(25));

        // Show the current inventory
        Console.WriteLine("== Inventory ==");
        inventory.PrintInventory();

        // Use the first item
        Console.WriteLine("\n== Using Slot 1 ==");
        inventory.UseItem(0);

        // Print inventory after use
        Console.WriteLine("\n== Inventory After Use ==");
        inventory.PrintInventory();
    }
}
