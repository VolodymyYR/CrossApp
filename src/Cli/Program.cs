using System.Runtime.InteropServices;
using System.Text;

// Встановлюю UTF-8 для правильного відображення українських літер.
Console.OutputEncoding = Encoding.UTF8;

// Виводжу назву роботи та свої дані.
Console.WriteLine("CrossApp — практикум з крос-платформного програмування");
Console.WriteLine("Студент: Яремкович Володимир, група ФЕІ-33");
Console.WriteLine(new string('-', 60));

// Показую операційну систему двома способами.
Console.WriteLine($"ОС (OSDescription): {RuntimeInformation.OSDescription}");
Console.WriteLine($"ОС (Environment): {Environment.OSVersion}");

// Показую архітектуру процесу та середовище виконання.
Console.WriteLine($"Архітектура процесу: {RuntimeInformation.ProcessArchitecture}");
Console.WriteLine($"Версія .NET (CLR): {Environment.Version}");
Console.WriteLine($"Runtime: {RuntimeInformation.FrameworkDescription}");

// Порівнюю розташування програми з поточним робочим каталогом.
Console.WriteLine($"Каталог застосунку: {AppContext.BaseDirectory}");
Console.WriteLine($"Поточний каталог: {Environment.CurrentDirectory}");

Console.WriteLine(new string('-', 60));

// Зазначаю предметну область для наступних лабораторних.
Console.WriteLine("Предметна область: Замовлення");
Console.WriteLine("Сутності: клієнт, товар, замовлення, рядок замовлення");