using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree
{

    


   

    internal class Human
    {
        private static int count = 0;
        private int id;
        private string name;
        private string surname;
        private string gender;
        private int age;
        private List<Human> children;
        private Human mother = null;
        private Human father = null;



        public Human(string name, string surname, string gender, int age) 
        { 
            this.name = name;
            this.surname = surname;
            this.gender = gender;
            this.age = age;
            count += 1;
            this.id = count;
            children = new List<Human>();
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }

        public string GetGender()
        {
            return gender;
        }

        public int GetAge()
        {
            return age;
        }

        public void AddChildren(Human child)
        {
            children.Add(child);
            if(gender.Equals("мужской"))
            {
                child.father = this;

            }
            else
            {
                child.mother = this;

            }
        }
        public void AddChildren(string name, string surname, string gender, int age)
        {
            
            AddChildren(new Human(name, surname, gender, age));
        }

        public Human GetChildren(int index)
        {
            return children[index];
        }

        public void ShowMother()
        {
            if(mother != null)
            {
                Console.WriteLine($"Мать: {mother.ToString}");
            }
            else
            {
                Console.WriteLine("Мать неизвестна!");
            }

        }

        public void ShowFather()
        {
            if (father != null)
            {
                Console.WriteLine($"Отец: {this.father.ToString()}");
            }
            else
            {
                Console.WriteLine("Отец неизвестен!");
            }

        }
       

        public void ShowChildren()
        {
            if(children != null && children.Count != 0)
            {
                foreach (var i in children)
                {
                    Console.Write(i.ToString);
                    Console.WriteLine("\n");

                }
            }
        }

        
        public override string ToString()
        {
            return $"Имя {name}, Фамилия {surname}, Возраст {age}";
            
        }

        public void Info(int indent = 0)
        {
            
            Console.WriteLine($"{new String('-', indent)}" +
                $"Имя {this.name} " +
                $"Фамилия {this.surname} " +
                $"Возраст {this.age}\n| " +
                $"{new String('-', indent+1)}Мать {this.mother?.ToString()}\n| " +
                $"{new String('-', indent+1)}Отец {this.father?.ToString()}");
            if (this.children.Count > 0)
            {
                foreach (var child in children)

                {
                    child.Info(indent * 2);
                }

            }
            
        }
       

    }
}
