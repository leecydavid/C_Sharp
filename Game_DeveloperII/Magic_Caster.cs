public class MagicCaster: Enemy
{
    public MagicCaster():base("Magic Caster", 80, new List<Attack>())
    {
        this.AttackList = new List<Attack>
        {
            new Attack("Fireball", 25),
            new Attack("Lightning Bolt", 20),
            new Attack("Staff Strike", 10)
        };
    }

    public void Heal(Enemy Target)
    {
        Target.HealEnemy(40);
        Console.WriteLine($"{Name} heals {Target.Name}, {Target.Name}'s health increased to {Target.Health}.");
    }
}