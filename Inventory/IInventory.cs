/// <summary>
/// Interface for an inventory system.
/// </summary>
public interface IInventory
{
    bool AddItem(IItem item);
    void UseItem(int slotIndex);
    void PrintInventory();
}
