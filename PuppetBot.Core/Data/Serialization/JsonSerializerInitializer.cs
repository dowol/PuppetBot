using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PuppetBot.Data.Serialization;

public static class JsonSerializerInitializer
{
    public static void Initialize(this JsonSerializerOptions options)
    {
        options.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        options.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;

        options.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault;

        options.Converters.Clear();

    }
}
