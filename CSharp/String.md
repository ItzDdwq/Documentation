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

## Модификация
- [Вернуться в начало](#Массивы)

#### ToLower()/ToUpper()
Преобразует регистр.
``` csharp
string s = "Hello World";

string upper = s.ToUpper();
string lower = s.ToLower();
```

#### Trim()
Удаляет пробелы(или указанный символ) в начале и конце.
``` csharp
string s = " Hello ";
string trimmed = s.Trim();
```

#### Trim()
Удаляет пробелы(или указанный символ) в начале и конце.
``` csharp
string s = " Hello ";
string trimmed = s.Trim();
```

#### TrimStart()/TrimEnd()
Удаляет только слева или только справа.
``` csharp
string s = " Hello ";
string trimmed = s.TrimStart();
string trimmed2 = s.TrimEnd();
```

#### Replace()
Меняет все вхождения одной подстроки на другую.
``` csharp
string s = "Hello";
string replaced = s.Replace("l", "L");
```

#### Replace()
Удаляет символы с указанной позиции.
``` csharp
string s = "Hello";
string replaced = s.Remove(2);
```

#### Insert()
Вставляет подстроку в указанную позицию.
``` csharp
string s = "Hello";
string inserted = s.Insert(6, "Beautiful"); // Ставит перед 6 подстроку
```

#### PadLeft()/PadRight()
Дополняет строку символами до нужной длины.
``` csharp
string s = "Hello";
string padleft = s.PadLeft(10, '0'); // Добавит перед Hello пять 0
string padright = s.PadRight(10, '0'); // Добавляет после Hello пять 0
```
---
---
