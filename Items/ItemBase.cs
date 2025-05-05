/// <summary>
/// Base class for all items. Implements IItem.
/// </summary>
public abstract class ItemBase : IItem
{
    public string Name { get; protected set; }

    /// <summary>
    /// Execute the item effect.
    /// </summary>
    public abstract void Use();
}
