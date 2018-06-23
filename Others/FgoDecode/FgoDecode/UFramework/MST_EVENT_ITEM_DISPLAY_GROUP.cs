using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_ITEM_DISPLAY_GROUP : IMessage, IMessage<MST_EVENT_ITEM_DISPLAY_GROUP>, IEquatable<MST_EVENT_ITEM_DISPLAY_GROUP>, IDeepCloneable<MST_EVENT_ITEM_DISPLAY_GROUP>
	{
		public const int EventIdFieldNumber = 1;

		public const int GroupIndexFieldNumber = 2;

		public const int TitleImageIdFieldNumber = 3;

		private static readonly MessageParser<MST_EVENT_ITEM_DISPLAY_GROUP> _parser = new MessageParser<MST_EVENT_ITEM_DISPLAY_GROUP>(() => new MST_EVENT_ITEM_DISPLAY_GROUP());

		private int eventId_;

		private int groupIndex_;

		private int titleImageId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_ITEM_DISPLAY_GROUP.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_ITEM_DISPLAY_GROUP> Parser => MST_EVENT_ITEM_DISPLAY_GROUP._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventItemDisplayGroupReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int EventId
		{
			get => this.eventId_;
			set
			{
				this.eventId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int GroupIndex
		{
			get => this.groupIndex_;
			set
			{
				this.groupIndex_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TitleImageId
		{
			get => this.titleImageId_;
			set
			{
				this.titleImageId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_GROUP()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_GROUP(MST_EVENT_ITEM_DISPLAY_GROUP other) : this()
		{
			this.eventId_ = other.eventId_;
			this.groupIndex_ = other.groupIndex_;
			this.titleImageId_ = other.titleImageId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_GROUP Clone()
		{
			return new MST_EVENT_ITEM_DISPLAY_GROUP(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_ITEM_DISPLAY_GROUP);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_ITEM_DISPLAY_GROUP other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.EventId == other.EventId && this.GroupIndex == other.GroupIndex && this.TitleImageId == other.TitleImageId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.GroupIndex != 0)
			{
				num ^= this.GroupIndex.GetHashCode();
			}
			if (this.TitleImageId != 0)
			{
				num ^= this.TitleImageId.GetHashCode();
			}
			return num;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			if (this.EventId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventId);
			}
			if (this.GroupIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.GroupIndex);
			}
			if (this.TitleImageId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TitleImageId);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.GroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupIndex);
			}
			if (this.TitleImageId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TitleImageId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_ITEM_DISPLAY_GROUP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.GroupIndex != 0)
			{
				this.GroupIndex = other.GroupIndex;
			}
			if (other.TitleImageId != 0)
			{
				this.TitleImageId = other.TitleImageId;
			}
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0u)
			{
				uint num2 = num;
				if (num2 != 8u)
				{
					if (num2 != 16u)
					{
						if (num2 != 24u)
						{
							input.SkipLastField();
						}
						else
						{
							this.TitleImageId = input.ReadInt32();
						}
					}
					else
					{
						this.GroupIndex = input.ReadInt32();
					}
				}
				else
				{
					this.EventId = input.ReadInt32();
				}
			}
		}
	}
}
