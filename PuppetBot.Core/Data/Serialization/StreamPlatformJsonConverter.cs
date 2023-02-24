using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PuppetBot.Data.Serialization
{
    public class StreamPlatformJsonConverter : JsonConverter<StreamPlatform>
    {
        public override StreamPlatform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }

        public override void Write(Utf8JsonWriter writer, StreamPlatform value, JsonSerializerOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
