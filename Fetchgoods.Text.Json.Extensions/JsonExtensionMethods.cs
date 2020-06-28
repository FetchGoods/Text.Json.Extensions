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
        
        #region string Extensions
        public static T FromJsonTo<T>(this string json)
        {
            return FromJson<T>(json, DefaultOptions);
        }

        public static T FromJson<T>(
            this string json, 
            JsonSerializerOptions options)
        {
            return JsonSerializer.Deserialize<T>(json, options);
        }


        #endregion

        #region object extensions
        public static string ToJson(this object value)
        {
            return ToJson<T>(value, DefaultOptions);
        }

        public static string ToJson<T>(this T value, JsonSerializerOptions options)
        {
            return JsonSerializer.Serialize<T>(value, options);
        }

        #endregion
    }
}
