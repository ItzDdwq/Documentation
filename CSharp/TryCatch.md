# TryCatch

[Назад в документацию](README.md)

Содержание:
- [Пример TryCatch](#пример-trycatch)

---
## Пример TryCatch
- [Вернуться в начало](#trycatch)

``` csharp
public void Run(){
    try
    {
        int zero = 0;
        int x = 10 / zero;
    }
    catch(DivideByZeroException ex)
    {
        Console.WriteLine("На ноль делить нельзя");
    }
}
```
---
---



