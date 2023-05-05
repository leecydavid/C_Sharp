public class MeleeFighter : Enemy
{
    public MeleeFighter():base("Melee Fighter", 120, new List<Attack>())
    {
        this.AttackList = new List<Attack>
        {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }

    public Attack Rage()
    {
        Attack ChosenAttack = this.RandomAttack();
        return new Attack(ChosenAttack.Name, ChosenAttack.Damage + 10);
    }
}