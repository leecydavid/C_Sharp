class Enemy 
{
    public string Name {get; protected set;} = "";
    public int Health {get; protected set;} = 100;
    public List<Attack> AttackList {get;}
    Random rand = new Random();

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

// Bonus: Write a method for adding Attacks to your Enemy's AttackList rather than having to call on the List's Add method in Program.cs
public void AddAttack(Attack A) => this.AttackList.Add(A);

public Attack RandomAttack() => this.AttackList[rand.Next(this.AttackList.Count)];
}