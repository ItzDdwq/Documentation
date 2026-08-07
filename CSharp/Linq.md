# Linq

[Назад в документацию](README.md)

Содержание:
- [Пример Linq](#пример-linq)

---
## Пример Linq
- [Вернуться в начало](#Лямбды)

``` csharp
public class Person 
{
    public string Name {set; get;}
    public int Age {set; get;}
    public string City {set; get;}
}

public class Test
{
    var people = new List<Person>
    {
        new Person { Name = "Ddwq", Age = 13, City = "Anapa" };
        new Person { Name = "Evgen", Age = 14, City = "Krasnodar" };
        new Person { Name = "Lev", Age = 14, City = "Kursk" };
    };

    var sorted = people.OrderBy(p => p.Age);
    var grouped = people.GroupedBy(p => p.City);
    var firstPasport = people.First(p => p.Age >= 14);
    bool hasPassport = people.Any(p => p.Age >= 14);
    int babyCount = people.Count(p => p.Age);
    int totalAge = people.Sum(p => p.Age);
}
```
---
---



