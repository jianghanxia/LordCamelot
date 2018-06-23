using Newtonsoft.Json;
using System;

namespace LordCamelot.Helper
{
	public class BoolConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue((bool)value ? 1 : 0);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			try
			{
				return Convert.ToBoolean(Convert.ToInt32(reader.Value));
			}
			catch (Exception)
			{
				// ignored
			}
			return null;
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(bool);
		}
	}

	public class DateTimeConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			writer.WriteValue(((bool)value) ? 1 : 0);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			try
			{
				var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
				dateTime = dateTime.AddSeconds(Convert.ToDouble(reader.Value));
				return dateTime.ToLocalTime();
			}
			catch (Exception)
			{
				// ignored
			}

			return DateTime.MinValue;
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(int);
		}
	}
}
