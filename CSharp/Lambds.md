# Лямбды

[Назад в документацию](README.md)

Содержание:
- [Пример лямбд 1](#пример-лямбд-1)
- [Пример лямбд 2](#пример-лямбд-2)

---
## Пример лямбд 1
- [Вернуться в начало](#Лямбды)

``` csharp
var numbers = new List<int> {1, 2, 3, 4, 5};

var result = numbers
        .Where(x => x % 2 == 0)
        .Select(x => x * 2)
        .ToList();

foreach(var item in result){
    Console.WriteLine(item);
}
```
---
---



## Пример лямбд 2
- [Вернуться в начало](#Лямбды)

``` csharp
var names = new List<string> {"Alice", "Bob", "Charlie", "David"};

var result = names.Where(name => name.Length > 3).ToList();

foreach(var name in result){
    Console.WriteLine(name);
}
```
---
---

