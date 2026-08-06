# ListsOperation

[Назад](Lists.md)

Содержание:
- [Добавление элементов](#добавление-элементов)
- [Удаление элементов](#удаление-элементов)
- [Поиск и проверка](#поиск-и-проверка)
- [Сортировка и изменение порядка](#сортировка-и-изменение-порядка)
- [Преобразование и копирование](#преобразование-и-копирование)
- [Информация о списке](#информация-о-списке)
- [Интерация](#интерация)

---


## Добавление элементов
- [Вернуться в начало](#listsoperation)

#### Add(T item)

- [Назад](#добавление-элементов)

Добавляет элемент в конец списка.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.Add(4);
```

#### AddRange(IEnumerable<T> collection)

- [Назад](#добавление-элементов)

Добавляет элементы коллекции в конец списка.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.AddRange(new[] {5, 6});
```

#### Insert(int index, T item)

- [Назад](#добавление-элементов)

Вставляет элемент в указанный индекс.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.Insert(0,0);
```

#### InsertRange(int index, IEnumerable<T> collection)

- [Назад](#добавление-элементов)

Вставляет коллекцию элементов начиная с указанного индекса.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.InsertRange(0, new[] {-2, -1});
```
---
---


## Удаление Элементов
- [Вернуться в начало](#listsoperation)

#### Remove(T item)

- [Назад](#удаление-элементов)

Удаляет первое вхождение указанного элемента.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.Remove(2);
```

#### RemoveAt(int index)

- [Назад](#удаление-элементов)

Удаляет элемент по индексу.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.RemoveAt(0);
```

#### RemoveRange(int index, int count)

- [Назад](#удаление-элементов)

Удаляет диапазон элементов.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.RemoveRange(0, 2);
```

#### RemoveAll(Predicate<T> match)

- [Назад](#удаление-элементов)

Удаляет все элементы, удовлетворяющие условию.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.RemoveAll(x => x > 3);
```

#### Clear()

- [Назад](#удаление-элементов)

Удаляет все элементы из списка.

``` csharp
var numbers = new List<int> {1,2,3};

numbers.Clear();
```
---
---


## Поиск и проверка
- [Вернуться в начало](#listsoperation)

#### Contains(T item)

- [Назад](#поиск-и-проверка)

Проверяет наличие элемента в списке.

``` csharp
var numbers = new List<int> {1,2,3};

bool cotains = numbers.Contains(3);
```

#### IndexOf(T item)

- [Назад](#поиск-и-проверка)

Возращает индекс первого вхождения элемента или -1.

``` csharp
var numbers = new List<int> {1,2,3};

int index = numbers.IndexOf(3);
```

#### IndexOf(T item, int startIndex)

- [Назад](#поиск-и-проверка)

Начинает искать объект с указанного индекса.

``` csharp
var numbers = new List<int> {1,2,3,4,5,6};

int index = numbers.IndexOf(2, 1);
```

#### LastIndexOf(T item)

- [Назад](#поиск-и-проверка)

Индекс последнего вхождения.

``` csharp
var numbers = new List<int> {1,2,3};

int lastIndex = numbers.LastIndexOf(2);
```

#### Find(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Находит первый элемент по условию.

``` csharp
var numbers = new List<int> {1,2,3};

int found = numbers.Find(x => x > 3);
```

#### FindLast(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Находит последний элемент по условию.

``` csharp
var numbers = new List<int> {1,2,3};

int foundLast = numbers.FindLast(x => x > 3);
```

#### FindAll(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Находит все элементы по условию.

``` csharp
var numbers = new List<int> {1,2,3};

var allFound = list.FindAll(x => x > 3);
```

#### FindIndex(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Индекс первого элемента по условию.

``` csharp
var numbers = new List<int> {1,2,3};

int foundIndex = numbers.FindIndex(x => x > 3);
```

#### FindLastIndex(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Индекс последнего элемента по условию.

``` csharp
var numbers = new List<int> {1,2,3};

int exists = numbers.Exists(x => x > 10);
```


#### TrueForAll(Predicate<T> match)

- [Назад](#поиск-и-проверка)

Проверяет, все ли элементы удовлетворяют условию.

``` csharp
var numbers = new List<int> {1,2,3};

int all = numbers.TrueForAll(x => x > 10);
```

#### BinarySearch(T item)

- [Назад](#поиск-и-проверка)

Бинарный поиск (список должен быть отсортирован).


---
---

## Сортировка и изменение порядка

- [Вернуться в начало](#listsoperation)

#### Sort()

- [Назад](#сортировка-и-изменение-порядка)

Сортирует список.

``` csharp
var numbers = new List<int> {4,2,5,1,3};

numbers.Sort();
```

#### Reverse()

- [Назад](#сортировка-и-изменение-порядка)


Меняет порядок элементов на обратный.

``` csharp
var numbers = new List<int> {4,2,5,1,3};

numbers.Reverse();
```

---
---


## Преобразование и копирование



- [Вернуться в начало](#listsoperation)

#### ToArray()

- [Назад](#преобразование-и-копирование)

Преобразует список в массив.

``` csharp
var numbers = new List<int> {4,2,5,1,3};

int[] array = numbers.ToArray();
```


#### GetRange(int index, int count)

- [Назад](#преобразование-и-копирование)

Возвращает новый список - копию диапазона.

``` csharp
var numbers = new List<int> {4,2,5,1,3};

var range = numbers.GetRange(1, 3);
```


#### AsReadOnly()

- [Назад](#преобразование-и-копирование)

Возвращает обёртку только для чтения (ReadOnlyCollection<T>).

``` csharp
var numbers = new List<int> {4,2,5,1,3};

var readOnly = numbers.AsReadOnly(); 
```


#### ConvertAll<TOutput>(Converter<T, TOutput>)

- [Назад](#преобразование-и-копирование)

Преобразует все элементы в другой тип.

``` csharp
var numbers = new List<int> {4,2,5,1,3};

var strings = numbers.ConvertAll(x => x.ToString());
```

---
---



## Информация о списке
- [Вернуться в начало](#listsoperation)

#### Count

- [Назад](#информация-о-списке)

Количество элементов в списке

``` csharp
var list = new List<int>(100);

list.AddRange(new[] {1,2,3});
Console.WriteLine(list.Count);
```
---
---


#### Capacity

- [Назад](#информация-о-списке)

Ёмкость внутреннего массива (можно задавать вручную).

``` csharp
var list = new List<int>(100);

list.AddRange(new[] {1,2,3});
Console.WriteLine(list.Capacity);
```


---
---


#### TrimExcess()

- [Назад](#информация-о-списке)

Уменьшает Capacity до фактического Count.

``` csharp
var list = new List<int>(100);

list.AddRange(new[] {1,2,3});
list.TrimExcess();
```


---
---


## Интерацияа
- [Вернуться в начало](#listsoperation)

#### ForEach(Action<T>)

- [Назад](#интерация)

Выполняет действие для каждого элемента.

``` csharp
var list = new List<int> {1, 2, 3};

list.ForEach(x => Console.WriteLine(x));
```
---
---


#### GetEnumerator()

- [Назад](#интерация)

Возвращает энумератор для foreach.

``` csharp
var list = new List<int> {1, 2, 3};

using var enumenator = list.GetEnumenator();
while(enumenator.MoveNext()){
    Console.WritLine(enumenator.Current);
}
```
---
---