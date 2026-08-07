# Методы расширений

[Назад в документацию](README.md)

Содержание:
- [Пример Метода](#пример-метода)

---
## Пример Метода
- [Вернуться в начало](#методы-расширений)

``` csharp
public static class StringExtensions{
    public static bool IsPalindrome(this string str){
        if(string.IsNullOrEmpty(str)) return false;

        var cleaned = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();

        var reversed = new string(cleaned.Reverse().ToArray());
        return cleaned == reversed;
    }
}


public void Run(){
    string word = "А роза упала на лапу Азора";
    bool result = word.IsPalindrome();
    Console.WriteLine(result);
}
```
---
---



