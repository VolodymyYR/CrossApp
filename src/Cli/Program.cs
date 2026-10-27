using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

// Встановлюю кодування для українських символів.
Console.OutputEncoding = Encoding.UTF8;

// Збираю інформацію один раз, щоб обидва формати містили однакові дані.
var info = new Dictionary<string, string>
{
    ["Назва"] = "CrossApp — практикум з крос-платформного програмування",
    ["Студент"] = "Яремкович Володимир",
    ["Група"] = "ФЕІ-33",
    ["ОС (OSDescription)"] = RuntimeInformation.OSDescription,
    ["ОС (Environment)"] = Environment.OSVersion.ToString(),
    ["Архітектура процесу"] = RuntimeInformation.ProcessArchitecture.ToString(),
    ["Версія .NET (CLR)"] = Environment.Version.ToString(),
    ["Runtime"] = RuntimeInformation.FrameworkDescription,
    ["Каталог застосунку"] = AppContext.BaseDirectory,
    ["Поточний каталог"] = Environment.CurrentDirectory,
    ["Предметна область"] = "Замовлення",
    ["Сутності"] = "клієнт, товар, замовлення, рядок замовлення"
};

// Перевіряю, чи передав я прапорець --json під час запуску.
if (args.Contains("--json"))
{
    var options = new JsonSerializerOptions
    {
        // Виводжу JSON одним рядком без відступів.
        WriteIndented = false,

        // Залишаю українські літери читабельними.
        Encoder = JavaScriptEncoder.Create(
            UnicodeRanges.BasicLatin,
            UnicodeRanges.Cyrillic)
    };

    Console.WriteLine(JsonSerializer.Serialize(info, options));
}
else
{
    // Без прапорця показую ті самі дані у двох стовпцях.
    Console.WriteLine($"{"Параметр",-24} | Значення");
    Console.WriteLine(new string('-', 90));

    foreach (var item in info)
    {
        Console.WriteLine($"{item.Key,-24} | {item.Value}");
    }
}