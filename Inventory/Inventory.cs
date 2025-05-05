/// <summary>
/// Simple inventory implementation with fixed-size slots.
/// </summary>
public class Inventory : IInventory
{
    private readonly InventorySlot[] _slots;

    public Inventory(int size)
    {
        _slots = new InventorySlot[size];

        for (int i = 0; i < size; i++)
            _slots[i] = new InventorySlot();
    }

    /// <summary>
    /// Adds an item to the first empty slot.
    /// </summary>
    public bool AddItem(IItem item)
    {
        foreach (var slot in _slots)
        {
            if (slot.IsEmpty)
            {
                slot.StoreItem(item);
                return true;
            }
        }

        Console.WriteLine("Inventory is full!");
        return false;
    }

    /// <summary>
    /// Uses an item from the given slot index.
    /// </summary>
    public void UseItem(int slotIndex)
    {
        if (slotIndex < 0 || slotIndex >= _slots.Length)
        {
            Console.WriteLine("Invalid slot index.");
            return;
        }

        _slots[slotIndex].UseItem();
    }

    /// <summary>
    /// Prints a list of all inventory slots and their contents.
    /// </summary>
    public void PrintInventory()
    {
        for (int i = 0; i < _slots.Length; i++)
        {
            string content = _slots[i].IsEmpty ? "[Empty]" : _slots[i].Item.Name;
            Console.WriteLine($"Slot {i + 1}: {content}");
        }
    }
}
