using System.Text.Json;

namespace Fetchgoods.Text.Json.Extensions
{
    public static class JsonExtensionMethods
    {
        public static JsonSerializerOptions DefaultOptions { get; set; }

        static JsonExtensionMethods()
        {
            DefaultOptions = new JsonSerializerOptions();
        }

        public static T FromJson<T>(this string json)
        {
            return FromJson<T>(json, DefaultOptions);
        }

        public static T FromJson<T>(
            this string json, 
            JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }

        public static string ToJson<T>(this T value)
        {
            return ToJson<T>(value, DefaultOptions);
        }

        public static string ToJson<T>(this T value, JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize<T>(value, options);
        }
    }
}
