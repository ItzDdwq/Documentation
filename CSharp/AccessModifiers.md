# Модификаторы Доступа

[Назад](Variables.md)

Содержание:
- [Public](#public)
- [Private](#private)
- [Protected](#protected)
- [Internal](#internal)
- [Protected Internal](#protected-internal)
- [Private Protected](#private-protected)


---


## Public
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен откуда угодно.
``` csharp
public decimal balance = 100; // Доступен везде
balance - 10; // Тоже где угодно
```

---
---


## Private
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен только внутри класса (по умолчанию)
``` csharp
private decimal balance = 100; // Доступен только внутри класса
balance - 10; // За пределами класса будет ошибка
```
---
---


## Protected
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен только внутри класса и в наследниках.
``` csharp
public class Person{
    protected string name = "Ddwq"; // Видно мне и наследникам
}

public class Admin : Person{
    Console.WriteLine(name); // Будет работать
}

Person person = new Person();
Console.WriteLine(person.Name); // Не будет работать
```
---
---


## Internal
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен только внутри текущей сборке (.dll или .exe).
``` csharp
internal class SecretService {
    internal long port = 8080; // Видно только внутри этого .dll
}

public class User{
    void Test(){
      SecretService s = new SecretService();
      Console.WriteLine(s.Port);
  }
}

// Но если сделать SecretService s = new SecretService(); в другом проекте то будет ошибка из за internal.

```

---
---


## Protected Internal
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен в сборке или у наследников.
``` csharp
public class Base
{
    protected internal int Value = 42;
}

// Наследник в другой сборке
public class Child : Base
{
    void Test() { Console.WriteLine(Value); } // ОК (потому что protected)
}

// Не наследник но в той же сборке 
public class Neighbor
{
    void Test(Base b) { Console.WriteLine(b.Value); } // ОК (потому что internal)
}

// Не наследник и в другой сборке
Console.WriteLine(b.Value); // ОШИПКА
```
---
---


## Private Protected
- [Вернуться в начало](#Модификаторы-доступа)

Объект доступен в сборке и у наследников (очень тяжело).
``` csharp
public class Base
{
    private protected int Secret = 999;
}

// Будет работать только если наследник в той же же сборке
public class ChildSameProject : Base
{
    void Test() { Console.WriteLine(Secret); } 
}
```
---
---
