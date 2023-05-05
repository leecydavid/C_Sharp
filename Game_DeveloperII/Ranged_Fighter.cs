public class RangedFighter : Enemy
{
    int Distance = 5;

    public RangedFighter():base("Ranged Fighter", new List<Attack>())
    {
        this.AttackList = new List<Attack>
        {
            new Attack("Shoot Arrow", 20),
            new Attack("Throw Knife", 15)
        };
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance < 10)
        {
            Console.WriteLine("Distance too short, cannot attack!");
        }
        else 
        {
            base.PerformAttack(Target, ChosenAttack);
        }
    }

    public void Dash() => Distance = 20;
}