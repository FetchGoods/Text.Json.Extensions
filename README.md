# Text.Json.Extensions
Provides convenience [extension methods][1] and [configurable default settings][2] for [.Net Core's JsonSerializer][3]

## Usage

```cs

using Fetchgoods.Text.Json.Extensions;

// ...

class Animal
{
    public string Species { get; set; }
    public int Legs { get; set; }
    public string Sound { get; set; }
}

string text = @"{""Species"": ""Cat"", ""Legs"": 4, ""Sound"": ""Meow!"" }";
            
var cat = text.FromJsonTo<Animal>();

// ...

```

[1]: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods
[2]: https://stackoverflow.com/questions/58331479/how-to-globally-set-default-options-for-system-text-json-jsonserializer
[3]: https://docs.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializer?view=netcore-3.1
