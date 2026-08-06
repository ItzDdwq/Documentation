using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Less1.Обучалки.Block2.Lists
{
    public class ListLess
    {
        public void Run()
        {
            // СОЗДАНИЕ СПИСКА
            // Пустой список
            List<int> list1 = new List<int>();
            
            // С значениями
            List<int> list2 = new List<int> {1, 2, 3, 4, 5};

            // Из другой коллекции
            int[] array = {1, 2, 3};
            List<int> list3 = new List<int>(array);

            // С ёмкостью (оптимизация)
            List<int> list4 = new List<int>(100);

            // ОПЕРАЦИИ
            List<string> fruits = new List<string>();

            // Добавление
            fruits.Add("Яблоко");
            fruits.AddRange(new[] {"Банан", "Апельсин"});
            fruits.Insert(1, "Груша");

            // Удаление
            fruits.Remove("Яблоко");
            fruits.RemoveAt(1);
            fruits.RemoveAll(f => f.StartsWith("A"));
            fruits.Clear();

            // Доступ к элементам
            string fitst = fruits[0];
            int count = fruits.Count;
            bool exist = fruits.Contains("Яблоко");
            int index = fruits.IndexOf("Груша");

            // Перебор элементов
            List<int> numbers = new List<int> {1, 2, 3, 4, 5};

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public void Run2()
        {
            List<int> nums = new List<int> {5, 3, 8, 1, 9};

            nums.Sort(); // Сортирует по порядку
            nums.Reverse(); // Разворот списка
            int max = nums.Max();
            int min = nums.Min();
            int sum = nums.Sum();
            bool any = nums.Any(x => x > 5);

            List<int> filtered = nums.Where(x => x > 3).ToList();
            List<int> doubled = nums.Select(x => x * 2).ToList();

            nums.Sort((a,b) => b.CompareTo(a));
        }

        public void Run3()
        {
            List<Person> people = new List<Person>()
            {
                new Person {Name = "Иван", Age = 25},
                new Person {Name = "ddwq", Age = 13}
            };

            Person found = people.Find(p => p.Name == "ddwq");
            
            people.Sort((a,b) => a.Age.CompareTo(b.Age));
        }

        public void Run4()
        {
            List<List<int>> matrix = new List<List<int>>
            {
                new List<int> {1,2,3},
                new List<int> {4,5,6},
                new List<int> {7,8,9}  
            };
        }
    }
}