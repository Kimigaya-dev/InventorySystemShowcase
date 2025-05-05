/// <summary>
/// An item that restores health when used.
/// </summary>
public class HealthPotion : ItemBase
{
    private readonly int _healAmount;

    public HealthPotion(int healAmount)
    {
        Name = "Health Potion";
        _healAmount = healAmount;
    }

    public override void Use()
    {
        // In a real game, you'd reference a Player object here and apply healing.
        Console.WriteLine($"You used a {Name}. Restored {_healAmount} HP.");
    }
}
