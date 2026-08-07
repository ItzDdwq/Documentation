# Interfaces

[Назад в документацию](README.md)

Содержание:
- [Создание Интерфейса](#создание-интерфейса)
- [Использование Интерфейса](#использование-интерфейса)

---
## Создание Интерфейса
- [Вернуться в начало](#interfaces)

``` csharp
public interface ISay{
    void playSound();
    string Name {set; get;}
}
```
---
---



## Использование Интерфейса
- [Вернуться в начало](#interfaces)

``` csharp
public class Test : ISay{
    public string Name {set; get;}
    public void playSound(){
        Console.WriteLine($"{Name} говорит что то.");
    }
}
```
---
---
