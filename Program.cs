Enemy Teemo = new Enemy("Teemo");

Attack Blind = new Attack("Blinding Dart", 15);
Attack Shroom = new Attack("Poison Shroom", 20);
Attack Auto = new Attack("Auto Attack", 10);

Teemo.AttackList.Add(Blind);
Teemo.AttackList.Add(Shroom);
Teemo.AttackList.Add(Auto);

Teemo.RandomAttack();