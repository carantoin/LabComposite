using System.Collections.Generic;
public interface IUnit
{
    void Attack();
}
public class Warrior : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Воин атакует мечом!");
    }
}
public class Mage : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Маг атакует заклинанием!");
    }
}
public class Archer : IUnit
{
    public void Attack()
    {
        Console.WriteLine("Лучник атакует из лука!");
    }
}
public class Squad : IUnit
{
    private string _name;
    private List<IUnit> _units = new List<IUnit>();

    public Squad(string name)
    {
        _name = name;
    }
    public void Add(IUnit unit)
    {
        _units.Add(unit);
    }
    public void Attack()
    {

        Console.WriteLine($"{_name} атакует!");


        foreach (var unit in _units)
        {
            unit.Attack();
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Тест 1");

        Squad army = new Squad("Армия");

        Squad squad1 = new Squad("Отряд 1");
        squad1.Add(new Warrior());
        squad1.Add(new Archer());

        Squad squad2 = new Squad("Отряд 2");
        squad2.Add(new Mage());
        squad2.Add(new Mage());

        Squad squad3 = new Squad("Отряд 3");
        squad3.Add(new Warrior());

        army.Add(squad1);
        army.Add(squad2);
        army.Add(squad3);

        army.Attack();

        Console.WriteLine("Тест 2");

        Squad mainSquad = new Squad("Главный отряд");

        mainSquad.Add(new Warrior());
        mainSquad.Add(new Mage());

        Squad secondSquad = new Squad("Второй отряд");
        secondSquad.Add(new Warrior());
        secondSquad.Add(new Mage());

        mainSquad.Add(secondSquad);
        mainSquad.Attack();
    }
}