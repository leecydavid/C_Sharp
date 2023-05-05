public class Attack
{
    public string Name {get; protected set;}
    public int Damage {get; protected set;}


// Constructor: When an Attack is created, we must specify the Name and DamageAmount upon creation
public Attack(string Name, int Damage)
{
    this.Name = Name;
    this.Damage = Damage;
}
}