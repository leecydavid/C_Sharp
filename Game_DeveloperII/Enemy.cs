public class Enemy
{
    public string Name {get; protected set;} = "";
    // get = able to retrieve information 
    // protected set = cannot changed the information
    public int Health {get; protected set;} = 100;
    public List<Attack> AttackList {get; protected set;}
    protected Random rand = new Random();

    public Enemy(string Name, int Health, List<Attack> AttackList)
    {
        this.Name = Name;
        this.Health = Health;
        this.AttackList = AttackList;
    }

    public Enemy(string Name, List<Attack> AttackList)
    {
        this.Name = Name;
        this.AttackList = AttackList;
    }

public void AddAttack(Attack A) => this.AttackList.Add(A);

public Attack RandomAttack() => this.AttackList[rand.Next(this.AttackList.Count)];

public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    Target.Health -= ChosenAttack.Damage;
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.Damage} damage and reducing {Target.Name}'s health to {Target.Health}!!");
}

public void HealEnemy(int Amount) => this.Health += Amount;

}