using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Спроектируйте программу для построения генеалогического дерева.
//Учтите что у нас есть члены семьи у кого нет детей(дет).
//Есть члены семьи у кого дети есть (взрослые).
//Есть мужчины и женщины.

//Доработать предыдущий класс реализовав методы вывода родителей, детей,
//братьев/сестер (включая двоюродных), бабушеки дедушек.
//Подумайте как лучше реализовать данные методы.

namespace FamilyTree
{
    internal class Tree
    {
        private List<Human> humanList = new List<Human>();

        public string AddHuman(Human human)
        {
            if (!humanList.Contains(human))
            {
                humanList.Add(human);
                return "Добавление прошло успешно";
            }
            else
            {
                return "Объект уже существует!";
            }
            
        }

        public void AddHuman()
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите пол");
            string gender = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            int age = int.Parse(Console.ReadLine());

            foreach(Human human in humanList)
            {
               if(!human.GetName().Equals(name)
                    && !human.GetSurname().Equals(surname)
                    && human.GetAge() != age)
                {
                    Console.WriteLine(AddHuman(new Human(name, surname, gender, age)));
                }
            }

                       
        }


        public void PrintTree()
        {

        }


    }
}
