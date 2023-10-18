using FamilyTree;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree tree = new Tree();
        Human human1 = new Human("Иван", "Федоров", "мужской", 89);
        human1.AddChildren("Денис", "Абрамов", "мужской", 50);
        human1.AddChildren("Егор", "Лукьянов", "мужской", 45);
        human1.GetChildren(0).AddChildren("Влад", "Абрамов", "мужской", 20);
        human1.GetChildren(1).AddChildren("Станислав", "Лукьянов", "мужской", 21);

      

       // human1.GetChildren(1).ShowFather();

        human1.Info(1);








    }
}