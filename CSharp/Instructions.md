# Инструкции

[Назад в документацию](README.md)

Содержание:
- [If-Else](#if-else)
- [For](#for)
- [ForEach](#foreach)
- [SwitchCase](#switchcase)
- [DoWhile](#dowhile)


---
## If-Else
- [Вернуться в начало](#Инструкции)

Условный оператор который выполняет блок кода если условие верно.

``` csharp
int a = 5;
if(a == 5){
  // Логка
} else if(a >= 10){
  // Логика
} else{
  // Выполнится если все условия False
}
```

---
---

## For
- [Вернуться в начало](#Инструкции)

Условный оператор который выполняет блок кода пока условие выполняется.

``` csharp
for (int i = 0; i<10; i++){
    Console.WriteLine(i);
}
```
---
---

## ForEach
- [Вернуться в начало](#Инструкции)

Условный оператор который перебирает данные, например из массива.

``` csharp
string[] names = {"Ddwq", "Jenya", "Aleksei"}
foreach(string name in names){
    Console.WriteLine(name);
}
```
---
---


## SwitchCase
- [Вернуться в начало](#Инструкции)

Оператор который меняет переменные в зависимости от полученных данных и условия.

``` csharp
string name = "Ddwq";
string title = "";
int level = 50;

switch(level){
  case 10:
    title = "Новичок";
    break;
  case 50:
    title = "Опытный";
    break;
  case 100:
    title = "Профессионал";
    break;
Console.WriteLine($"Меня зовут {name}, у меня {level} уровень и я {title}");
```
---
---

## DoWhile
- [Вернуться в начало](#Инструкции)

Условный оператор который перебирает данные, например из массива.

``` csharp
string choice = "";
do{
    Console.WriteLine("Играть - 1");
    Console.WriteLine("Выйти - 2");
    Console.Write("Введите: ");

    choice = Console.ReadLine();

    if(choice == "1"){
        // Метод для начала игры
    }
} while(choice != "2");
```
---
---
