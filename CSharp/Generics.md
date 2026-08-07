# Generics

[Назад в документацию](README.md)

Содержание:
- [Создание Generics](#создание-generics)
- [Объявление Generics](#объявление-generics)

---
## Создание Generics
- [Вернуться в начало](#generics)

``` csharp
class Box<T>{
    public T Content {set; get;}

    public void ShowContent(){
        Console.WriteLine(Content);
    }
}

public class Phone{
    public string Model {set; get;}
}

public class Person{
    public string Name {set; get;}
    public int Age {set; get;}
}
```
---
---



## Объявление Generics
- [Вернуться в начало](#generics)

``` csharp
public void Run(){
    Box<Phone> phoneBox = new Box<Phone>();
    phoneBox.Content = new Phone() {Model = "iPhone 17 Pro Max"};
    Console.WriteLine(phoneBox.Content.Model);

    Box<Person> personBox = new Box<Person>();
    personBox.Content = new Phone() {Name = "ItzDdwq", Age = 13};
    Console.WriteLine(personBox.Content);
    personBox.ShowContent();
}
```
---
---
