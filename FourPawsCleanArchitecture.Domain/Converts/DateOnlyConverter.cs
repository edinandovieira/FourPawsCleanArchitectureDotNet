using System.Text.Json.Serialization;
using System.Text.Json;

namespace FourPawsCleanArchitecture.Domain.Converts
{
    public class DateOnlyConverter : JsonConverter<DateTime>
    {
        public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Lógica de leitura (opcional)
            return reader.GetDateTime();
        }

        public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
        {
            // Escreve apenas a data no formato desejado
            writer.WriteStringValue(value.Date.ToString("yyyy-MM-dd"));
        }
    }
}
