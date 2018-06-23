using Google.Protobuf.Reflection;
using System;

namespace UFramework
{
	public static class MstCardReflection
	{
		private static FileDescriptor descriptor;

		public static FileDescriptor Descriptor => MstCardReflection.descriptor;

		static MstCardReflection()
		{
			byte[] descriptorData = Convert.FromBase64String(string.Concat(new string[]
			{
				"Cg5tc3RfY2FyZC5wcm90bxIKdUZyYW1ld29yayK9AQoITVNUX0NBUkQSCgoC",
				"aWQYASABKAUSCwoDbnVtGAIgASgFEhIKCmFkanVzdF9hdGsYAyABKAUSFwoP",
				"YWRqdXN0X3RkX2dhdWdlGAQgASgFEhcKD2FkanVzdF9jcml0aWNhbBgFIAEo",
				"BRIPCgdhZGRfYXRrGAYgASgFEhQKDGFkZF90ZF9nYXVnZRgHIAEoBRIUCgxh",
				"ZGRfY3JpdGljYWwYCCABKAUSFQoNaW5kaXZpZHVhbGl0eRgJIAMoBSI1Cg5N",
				"U1RfQ0FSRF9BUlJBWRIjCgVpdGVtcxgBIAMoCzIULnVGcmFtZXdvcmsuTVNU",
				"X0NBUkRiBnByb3RvMw=="
			}));
			MstCardReflection.descriptor = FileDescriptor.FromGeneratedCode(descriptorData, new FileDescriptor[0], new GeneratedClrTypeInfo(null, new GeneratedClrTypeInfo[]
			{
				new GeneratedClrTypeInfo(typeof(MST_CARD), MST_CARD.Parser, new string[]
				{
					"Id",
					"Num",
					"AdjustAtk",
					"AdjustTdGauge",
					"AdjustCritical",
					"AddAtk",
					"AddTdGauge",
					"AddCritical",
					"Individuality"
				}, null, null, null),
				new GeneratedClrTypeInfo(typeof(MST_CARD_ARRAY), MST_CARD_ARRAY.Parser, new string[]
				{
					"Items"
				}, null, null, null)
			}));
		}
	}
}
