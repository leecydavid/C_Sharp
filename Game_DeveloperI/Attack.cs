class Attack 
{
    public string Name {get; protected set;}
    public int Damage {get; protected set;}


public Attack(string Name, int Damage)
{
    this.Name = Name;
    this.Damage = Damage;
}
}

