// Worked with Kirstie, Stephen, Minh

// 1. Create instances of the Melee, Ranged, and Magic Caster classes
MeleeFighter Melee = new MeleeFighter();
RangedFighter Ranged = new RangedFighter();
MagicCaster Magic = new MagicCaster();

// 2. Perform the Kick Attack from your Melee class character on your Ranged character
Melee.PerformAttack(Ranged, Melee.AttackList[1]);
// 3. Perform the Rage method from your Melee class character on your Magic Caster character
Melee.PerformAttack(Magic, Melee.Rage());
// 4. Perform the Shoot an Arrow Attack from your Ranged character on your Melee character 
Ranged.PerformAttack(Melee, Ranged.AttackList[0]);
// 5. Have your Ranged character perform the Dash method
Ranged.Dash();
// 6. Perform another Shoot an Arrow Attack from your Ranged character 
Ranged.PerformAttack(Melee, Ranged.AttackList[0]);
// 7. Perform a Fireball Attack from your Magic Caster on your Melee character
Magic.PerformAttack(Melee, Magic.AttackList[0]);
// 8. Have the Magic Caster perform the Heal method on the Ranged character
Magic.Heal(Ranged);
// 9. Have the Magic Caster perform the Heal method on themselves
Magic.Heal(Magic);


