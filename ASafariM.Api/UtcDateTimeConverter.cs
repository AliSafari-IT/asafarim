using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serilog;

namespace ASafariM.Api
{
    /// <summary>
    /// Custom JsonConverter for handling DateTime and DateTimeOffset, ensuring UTC representation
    /// and serializing in standard ISO 8601 format ("yyyy-MM-ddTHH:mm:ss.fffZ").
    /// Handles potential null values for nullable DateTime?.
    /// </summary>
    public class UtcDateTimeConverter : JsonConverter<DateTime?>
    {
        private const string Format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"; // ISO 8601 format

        public override DateTime? Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                if (reader.TryGetDateTime(out DateTime dateTime))
                {
                    // Assume UTC if no offset is specified, otherwise respect the offset
                    return dateTime.Kind switch
                    {
                        DateTimeKind.Utc => dateTime,
                        DateTimeKind.Local => dateTime.ToUniversalTime(),
                        _ => DateTime.SpecifyKind(dateTime, DateTimeKind.Utc), // Assume UTC if unspecified
                    };
                }
                // Handle just date "yyyy-MM-dd" format - assume midnight UTC
                if (DateTime.TryParse(reader.GetString(), out dateTime))
                {
                    Log.Information("Parsed date: {DateTime}", dateTime);
                    return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
                }
            }

            // Fallback for unexpected types or invalid formats
            throw new JsonException($"Unable to convert \"{reader.GetString()}\" to DateTime.");
        }

        public override void Write(
            Utf8JsonWriter writer,
            DateTime? value,
            JsonSerializerOptions options
        )
        {
            Log.Information("Writing Nullable DateTime: {Value}", value); // Add log here
            if (value.HasValue)
            {
                // Ensure the DateTime is UTC before formatting
                DateTime utcValue =
                    value.Value.Kind == DateTimeKind.Utc
                        ? value.Value
                        : value.Value.ToUniversalTime();

                // Format using standard ISO 8601 format
                writer.WriteStringValue(utcValue.ToString(Format));
            }
            else
            {
                writer.WriteNullValue();
            }
        }
    }

    // Optional: Add a converter for non-nullable DateTime as well if needed
    public class UtcDateTimeNotNullableConverter : JsonConverter<DateTime>
    {
        private const string Format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff'Z'"; // ISO 8601 format

        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                if (reader.TryGetDateTime(out DateTime dateTime))
                {
                    // Assume UTC if no offset is specified, otherwise respect the offset
                    return dateTime.Kind switch
                    {
                        DateTimeKind.Utc => dateTime,
                        DateTimeKind.Local => dateTime.ToUniversalTime(),
                        _ => DateTime.SpecifyKind(dateTime, DateTimeKind.Utc), // Assume UTC if unspecified
                    };
                }
                // Handle just date "yyyy-MM-dd" format - assume midnight UTC
                if (DateTime.TryParse(reader.GetString(), out dateTime))
                {
                    Log.Information("Parsed date: {DateTime}", dateTime);
                    return DateTime.SpecifyKind(dateTime, DateTimeKind.Utc);
                }
            }
            throw new JsonException($"Unable to convert \"{reader.GetString()}\" to DateTime.");
        }

        public override void Write(
            Utf8JsonWriter writer,
            DateTime value,
            JsonSerializerOptions options
        )
        {
            Log.Information("Writing DateTime: {Value}", value);
            // Ensure the DateTime is UTC before formatting
            DateTime utcValue = value.Kind == DateTimeKind.Utc ? value : value.ToUniversalTime();

            // Format using standard ISO 8601 format
            writer.WriteStringValue(utcValue.ToString(Format));
        }
    }
}
