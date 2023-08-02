public class Enemy
{
    public string Name {get; set;}
    public int Health {get; set;}

    //Make Enemy's Health attribute private and add a Public version that lets us just see the value of private health

    public List<Attack> AttackList {get; set;}

    public Enemy (string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
        Console.WriteLine($"A new enemy, {Name}, has arrived!");
    }

    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        Attack randomAttack = AttackList[rand.Next(0, AttackList.Count)];
        Console.WriteLine(randomAttack.Name);
        return randomAttack;
    }

}