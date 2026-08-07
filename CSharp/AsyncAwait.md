# Асинхронность

[Назад в документацию](README.md)

Содержание:
- [Создание Асинхронности](#создание-асинхронности)

---
## Создание Асинхронности
- [Вернуться в начало](#Асинхронность)

``` csharp
public async Task RunAsync(){
    Console.WriteLine("Начинаю заугрузку");
    string content = await DownloadContentAsync("https://example.com");
    Console.WriteLine($"Загружено {content.Length} символов"); 
}

public async Task<string> DownloadContentAsync(string url){
    using HttpClient client = new HttpClient();
    return await client.GetStringAsync(url);
}
```
---
---

