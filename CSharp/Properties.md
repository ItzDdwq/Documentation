# Properties

[Назад в документацию](README.md)

Содержание:
- [Объявление](#объявление)
- [Изменение Данных](#изменение-данных)


---
## Объявление
- [Вернуться в начало](#Массивы)

``` csharp
public class Person{
    public string Name {set; get;}
    public int Age {set; get;}
}

public class Home{
    public void Run(){
        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");
    }
}
```
---
---


## Изменение Данных
- [Вернуться в начало](#Массивы)

``` csharp
public class Person{
    public string Name {set; get;}
    public int Age {set; get;}
}

public class Home{
    public void Run(){
        Person person = new Person();
        person.Name = ("ddwq");
        person.Age = 13;
        
        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");
    }
}

```
---
---

