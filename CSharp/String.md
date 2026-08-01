# Строки

[Назад в документацию](README.md)

Содержание:
- [Базовые методы](#базовые-методы)
- [Поиск и проверка содержимого](#поиск-и-проверка-содержимого)
- [Модификации](#модификации)
- [Разделение и объединение](#разделение-и-объединение)
- [Форматирование](#форматирование)
- [Работа с массивами символов](#работа-с-массивами-символов)
- [Дополнительные полезные методы](#дополнительные-полезные-методы)


---
## Базовые Методы
- [Вернуться в начало](#Строки)

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
- [Вернуться в начало](#Строки)

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

## Модификации
- [Вернуться в начало](#Строки)

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

## Разделение и объединение
- [Вернуться в начало](#Строки)

#### Split()
Разбивает строку на массив подстрок по разделителю.
``` csharp
string csv = "apple,banana,orange";
string[] fruits = csv.Split(','); // ["apple", "banana", "orange"]
```

#### Join()
Объединяет массив строк в одну с указанным разделителем.
``` csharp
string csv = "apple,banana,orange";
string[] fruits = csv.Split(',');
string joined = string.Join(";", fruits);
```

#### Concat()
Объединяет несколько строк.
``` csharp
string s1 = "Hello";
string s2 = "World";
string concat = string.Concat(s1,s2);
```
---
---

## Форматирование
- [Вернуться в начало](#Строки)

#### Format()
Подставляет значение в строку с плейсхолдерами.
``` csharp
string name = "Ddwq";
int age = 13;
string result = string.Format("Name = {0}, Age = {1}", name, age);
```
---
---

## Работа с массивами символов
- [Вернуться в начало](#Строки)

#### ToCharArray()
Преобразует строку в массив символов.
``` csharp
string s = "Hello;
char[] chars = s.ToCharArray();
```

#### new string(char[])
Создаёт строку из массива символов.
``` csharp
char[] chars = {'H', 'e', 'l', 'l', 'o');
string s = new string(chars);
```
---
---

## Дополнительные полезные методы
- [Вернуться в начало](#Строки)

#### ToString()
Возвращает саму строку.
``` csharp
int number = 123;
string str = number.ToString();
```

#### Clone()
Создаёт копию строки.
``` csharp
string s1 = "Hello";
string s2 = (string)s1.Clone();
```

#### GetEnumerator()
Позволяет итерироваться по символам.
``` csharp
string s = "Hello";
foreach (char c in s){
    Console.WriteLine(c);
}
```

#### Compare()
Статическое сравнение двух строк с учётом культуры.
``` csharp
int result = string.Compare("apple", "banana");
```

#### Copy()
Создает новую строку с тем же содержимым.
``` csharp
string s1 = "Hello";
string s2 = string.Copy(s1);
```
---
---
