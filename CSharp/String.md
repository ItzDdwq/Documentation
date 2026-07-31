# Строки

[Назад в документацию](README.md)

Содержание:
- [Базовые методы](#базовые-методы)
- [Поиск и проверка содержимого](#поиск-и-проверка-содержимого)
- [Массив с массивами](#массив-с-массивами)


---
## Базовые Методы
- [Вернуться в начало](#Массивы)

#### Length
Кол-во символов в строке.
``` csharp
string a = "Hello";
int len = a.Length; // 5
```

#### [index]
Можно получить символ по индексу.
``` csharp
string s = "Hello world";
char ch = s[1]; // 'e'
```

---
---

## Поиск и проверка содержимого
- [Вернуться в начало](#Массивы)

#### Contains()
Содержит ли строка подстроку или символ.
``` csharp
string s = "Hello World";
bool has = s.Contains("World");
```

#### StartsWith() / EndsWith()
Начинается/заканчивается ли строка на подстроку.
``` csharp
string s = "Hello world";
bool start = s.StartsWith("Hello");
bool end = s.EndWith("Hello");
```

#### IndexOf()
Индекс первого нахождения подстроки.
``` csharp
string s = "Hello world";
int index = s.IndexOf('o');
```

#### LastIndexOf()
Индекс последнего нахождения подстроки.
``` csharp
string s = "Hello world";
int index = s.IndexOf('o');
```

#### IndexOfAny()
Ищет первый символ из указанного массива.
``` csharp
string text = "Hello, World!";

char[] charsToFind = { '0', '1', '2', ',', '!' };
int index = text.IndexOfAny(charsToFind);

Console.WriteLine(index); // 5, потому что ',' в text находится на 5
```
---
---
