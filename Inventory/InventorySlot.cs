/// <summary>
/// Represents a single inventory slot which can store one item.
/// </summary>
public class InventorySlot
{
    public IItem Item { get; private set; }

    public bool IsEmpty => Item == null;

    /// <summary>
    /// Stores an item in the slot if it's empty.
    /// </summary>
    public void StoreItem(IItem item)
    {
        if (!IsEmpty)
            throw new InvalidOperationException("Slot is already occupied.");

        Item = item;
    }

    /// <summary>
    /// Uses the item in the slot and clears it afterwards.
    /// </summary>
    public void UseItem()
    {
        if (IsEmpty)
        {
            Console.WriteLine("Nothing to use in this slot.");
            return;
        }

        Item.Use();
        Item = null; // Remove item after use
    }
}
