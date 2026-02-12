using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JSONist
{
    internal class TIPLOCConversionEngine
    {
        public Object? ds(string input)
        {
            var options = new JsonSerializerOptions
            {
                IncludeFields = true, // REQUIRED for public fields
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
                Converters =
                {
                    // Map the custom logic for your Enums
                    new CustomEnumConverter<TIPLOCSchemaProvider.BPTP>(
                        TIPLOCSchemaProvider.ConvertToBPlan_TimingPoint),
                    new CustomEnumConverter<TIPLOCSchemaProvider.StationType>(
                        TIPLOCSchemaProvider.ConvertToTPS_StationType),
                    new CustomEnumConverter<TIPLOCSchemaProvider.StationCategory>(
                        TIPLOCSchemaProvider.ConvertToTPS_StationCategory),
                    new CustomEnumConverter<TIPLOCSchemaProvider.ForceLPB>(
                        TIPLOCSchemaProvider.ConvertToForceLPB)
                }
            };
            try
            {
                return JsonSerializer.Deserialize<TIPLOCSchemaProvider.Jfile>(input, options);

            }
            catch (JsonException ex)
            {
                return ex;
            }
        }

        public class CustomEnumConverter<T> : JsonConverter<T> where T : struct, Enum
        {
            private readonly Func<string?, T> _converter;

            public CustomEnumConverter(Func<string?, T> converter)
            {
                _converter = converter;
            }

            public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return _converter(reader.GetString());
            }

            public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(value.ToString());
            }
        }
    }
}
