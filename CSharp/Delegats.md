# Делегаты

[Назад в документацию](README.md)

Содержание:
- [Объявление](#объявление)
- [Методы](#методы)
- [Создание экземпляра](#создание-экземпляра)
- [Встроенные делегаты](#встроенные-делегаты)
- [Анонимные методы](#анонимные-методы)
- [Лямбда выражения](#лямбда-выражения)
- [Multicast](#multicast)
- [События на основе делегатов](#события-на-основе-делегатов)
- [Ковариантность и контравариантность](#ковариантность-и-контравариантность)
- [Callback функции](#callback-функции)
- [Делегаты как стратегии](#делегаты-как-стратегии)
- [Делегаты с замыканием](#делегаты-с-замыканием)

---
## Объявление
- [Вернуться в начало](#делегаты)

``` csharp
public delegate int Operation(int x, int y);
```
---
---


## Методы
- [Вернуться в начало](#делегаты)

``` csharp
static int Add(int a, int b) => a+b;
static int Multiply(int a, int b) => a*b;
```
---
---


## Создание экземпляра

- [Вернуться в начало](#делегаты)

``` csharp
Operation op = Add;
int result = op(3, 5);
Console.WriteLine(result);

op = Multiply;
result = op(3, 5);
Console.WriteLine(result);
```
---
---


## Встроенные делегаты

- [Вернуться в начало](#делегаты)

#### Action

- [Назад](#встроенные-делегаты)

Ничего не возвращает.

``` csharp
// Action - 0 параметров
Action greet = () => Console.WriteLine("Hello");
greet();

// Action - 1 параметр
Action<string> print = message => Console.WriteLine(message);
print("Привет");

// Action<T1, T2, T3 ..., T16> - до 16 параметров
Action<int, int> sum = (a, b) => Console.WriteLine(a + b);
sum(3, 5);
```
---
---


#### Func

- [Назад](#встроенные-делегаты)

Возвращает значение.

``` csharp
// Func<TResult> - без параметров, возвращает TResult
Func<int> getRandom = () => new Random().Next(1, 100);
Console.WriteLine(getRandom());

// Func<T, TResult> - 1 параметр
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

// Func<T1, T2, TResult> - 2 параметра
Func<int, int, int> add = (a,b) => a+b;
Console.WriteLine(add(3, 7));
```
---
---


#### Predicate

- [Назад](#встроенные-делегаты)

Всегда возвращает boolean.

``` csharp
// Predicate<T> - эквивалент Func<T, bool>
Predicate<int> isPositive = x => x > 0;
Console.WriteLine(isPositive(5)); // True
Console.WriteLine(isPositive(-3)); // False

// Часто используется в List<T>
var numbers = new List<int> {-2, -1, 0, 1, 2};
var positiveNumbers = numbers.FindAll(isPositive);
```
---
---


## Анонимные методы

- [Вернуться в начало](#делегаты)

``` csharp
// Анонимный метод с delegate
Operation op = delegate(int a, int b){
    return a - b;
};
Console.WriteLine(op(10, 3));

// С замыканием 
int multiplier = 10;
Func<int, int> multiplyBy = delegate(int x){
    return x * multiplier;
};
Console.WriteLine(multiplyBy(5));
```
---
---


## Лямбда выражения

- [Вернуться в начало](#делегаты)

``` csharp
// Лямбда-выражение (операторная форма)
Operation op1 = (a, b) => { return a / b; };

// Лямбда-выражение (выражение-тело)
Operation op2 = (a, b) => a % b;

// Опускание типов параметров
Func<int, int, int> op3 = (x, y) => x + y;

// Один параметр — скобки не обязательны
Func<int, int> square = x => x * x;

// Без параметров 
Action print = () => Console.WriteLine("Hello Lambda");
```
---
---


## Multicast

- [Вернуться в начало](#делегаты)

``` csharp
public delegate void Notify(string message);

static void LogToConsole(string msg) => Console.WriteLine($"Консоль: {msg}");
static void LogToFile(string msg) => Console.WriteLine($"Файл: {msg}");
static void SendEmail(string msg) => Console.WriteLine($"Email: {msg}");

// Комбинирование делегатов
Notify notifier = LogToConsole;
notifier += LogToFile;
notifier += SendEmail;

notifier("Важноe уведомление!");
// Вывод: 
// Консоль: Важное уведомление!
// Файл: Важное уведомление!
// Email: Важное уведомление!

// Удаление метода
notifier -= SendEmail;
notifier("Тест");
// Вывод:
// Консоль: Тест
// Файл: Тест

// Проверка на null перед вызовом
notifier?.Invoke("Безопасный вызов");
```
---
---


## События на основе делегатов

- [Вернуться в начало](#делегаты)

``` csharp
public class Button{
    public event EventHandler Click;

    public event Action<string> Notify;

    public void OnClick(){
        Click?.Invoke(this, EventArgs.Empty);
        Notify?.Invoke("Кнопка нажата");
    }
}

var button = new Button();

button.Click += (sender, args) =>
    Console.WriteLine("Клик!");

button.Notify += message =>
    Console.WriteLine($"Уведомление: {message}");

button.OnClick();
```
---
---


## Ковариантность и контравариантность

- [Вернуться в начало](#делегаты)

``` csharp
public delegate object ObjectDelegate();
public delegate string StringDelegate();

static string GetString() => "Hello";

StringDelegate stringDel1 = GetString;
ObjectDelegate objectDel1 = stringDel;

public delegate void StringAction(string s);
public delegate void ObjectAction(object o);

static void ProcessObject(object obj) => Console.WriteLine(obj);

ObjectAction objectAction = ProcessObject;
StringAction stringAction = objectAction;
```
---
---


## CallBack функции

- [Вернуться в начало](#делегаты)

``` csharp
public static void ProcessData(int[] data, Action<int> onProgress, Action onComplete)
{
    for (int i = 0; i < data.Length; i++)
    {
        // Обработка данных
        data[i] *= 2;
        
        // Вызов callback о прогрессе
        onProgress?.Invoke((i + 1) * 100 / data.Length);
    }
    
    // Вызов callback о завершении
    onComplete?.Invoke();
}

// Использование
var numbers = new[] { 1, 2, 3, 4, 5 };

ProcessData(
    numbers,
    progress => Console.WriteLine($"Прогресс: {progress}%"),
    () => Console.WriteLine($"Готово! Результат: {string.Join(", ", numbers)}")
);
```
---
---



## Делегаты как стратегии

- [Вернуться в начало](#делегаты)

``` csharp
public class Calculator
{
    private Func<int, int, int> _strategy;
    
    public Calculator(Func<int, int, int> strategy)
    {
        _strategy = strategy;
    }
    
    public void SetStrategy(Func<int, int, int> strategy)
    {
        _strategy = strategy;
    }
    
    public int Execute(int a, int b) => _strategy(a, b);
}

var calc = new Calculator((a, b) => a + b);
Console.WriteLine(calc.Execute(5, 3)); // 8

calc.SetStrategy((a, b) => a * b);
Console.WriteLine(calc.Execute(5, 3)); // 15

calc.SetStrategy(Math.Max);
Console.WriteLine(calc.Execute(5, 3)); // 5
```
---
---


## Делегаты с замыканием 

- [Вернуться в начало](#делегаты)

``` csharp
public static Func<int> CreateCounter()
{
    int count = 0; // эта переменная "живёт" внутри делегата
    
    return () => 
    {
        count++;
        return count;
    };
}

var counter1 = CreateCounter();
Console.WriteLine(counter1()); // 1
Console.WriteLine(counter1()); // 2
Console.WriteLine(counter1()); // 3

var counter2 = CreateCounter();
Console.WriteLine(counter2());
```
---
---
