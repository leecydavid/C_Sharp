// Worked with Stephen, Kirstie, Minh 

// Create 3 instances of Attacks in Program.cs
List<Attack> X = new List<Attack>
{
    new Attack("Fireball", 50),
    new Attack("Waterball", 25),
    new Attack("Bodyslam", 75)
};

// Create an instance of an Enemy in Program.cs
Enemy Y = new Enemy("Your Mom", 300, X);

// Call on your Enemy's RandomAttack method to test that they can now perform the given Attacks
Console.WriteLine(Y.RandomAttack().Name);

// Bonus: Practice good programming by making the Enemy's Health attribute private and adding a Public version that lets us just see the value of private health
// Y.Health = 100;
Console.WriteLine(Y.Health);

Y.AddAttack(new Attack("1000 years of pain", 100));
foreach(Attack Z in Y.AttackList)
{
    Console.WriteLine(Z.Name);
}




