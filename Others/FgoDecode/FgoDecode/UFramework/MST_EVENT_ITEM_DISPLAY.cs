using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_ITEM_DISPLAY : IMessage, IMessage<MST_EVENT_ITEM_DISPLAY>, IEquatable<MST_EVENT_ITEM_DISPLAY>, IDeepCloneable<MST_EVENT_ITEM_DISPLAY>
	{
		public const int IdFieldNumber = 1;

		public const int EventIdFieldNumber = 2;

		public const int ScreenFlagFieldNumber = 3;

		public const int ItemIdFieldNumber = 4;

		public const int GroupIndexFieldNumber = 5;

		public const int PriorityFieldNumber = 6;

		public const int ConditionDetailIdsFieldNumber = 7;

		public const int OpenedAtFieldNumber = 8;

		public const int ClosedAtFieldNumber = 9;

		private static readonly MessageParser<MST_EVENT_ITEM_DISPLAY> _parser = new MessageParser<MST_EVENT_ITEM_DISPLAY>(() => new MST_EVENT_ITEM_DISPLAY());

		private int id_;

		private int eventId_;

		private int screenFlag_;

		private int itemId_;

		private int groupIndex_;

		private int priority_;

		private static readonly FieldCodec<int> _repeated_conditionDetailIds_codec = FieldCodec.ForInt32(58u);

		private readonly RepeatedField<int> conditionDetailIds_ = new RepeatedField<int>();

		private ulong openedAt_;

		private ulong closedAt_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_ITEM_DISPLAY.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_ITEM_DISPLAY> Parser => MST_EVENT_ITEM_DISPLAY._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventItemDisplayReflection.Descriptor.MessageTypes[0];

		[DebuggerNonUserCode]
		public int Id
		{
			get => this.id_;
			set
			{
				this.id_ = value;
			}
		}

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
		public int ScreenFlag
		{
			get => this.screenFlag_;
			set
			{
				this.screenFlag_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int ItemId
		{
			get => this.itemId_;
			set
			{
				this.itemId_ = value;
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
		public int Priority
		{
			get => this.priority_;
			set
			{
				this.priority_ = value;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ConditionDetailIds => this.conditionDetailIds_;

		[DebuggerNonUserCode]
		public ulong OpenedAt
		{
			get => this.openedAt_;
			set
			{
				this.openedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public ulong ClosedAt
		{
			get => this.closedAt_;
			set
			{
				this.closedAt_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY(MST_EVENT_ITEM_DISPLAY other) : this()
		{
			this.id_ = other.id_;
			this.eventId_ = other.eventId_;
			this.screenFlag_ = other.screenFlag_;
			this.itemId_ = other.itemId_;
			this.groupIndex_ = other.groupIndex_;
			this.priority_ = other.priority_;
			this.conditionDetailIds_ = other.conditionDetailIds_.Clone();
			this.openedAt_ = other.openedAt_;
			this.closedAt_ = other.closedAt_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY Clone()
		{
			return new MST_EVENT_ITEM_DISPLAY(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_ITEM_DISPLAY);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_ITEM_DISPLAY other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.EventId == other.EventId && this.ScreenFlag == other.ScreenFlag && this.ItemId == other.ItemId && this.GroupIndex == other.GroupIndex && this.Priority == other.Priority && this.conditionDetailIds_.Equals(other.conditionDetailIds_) && this.OpenedAt == other.OpenedAt && this.ClosedAt == other.ClosedAt));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EventId != 0)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this.ScreenFlag != 0)
			{
				num ^= this.ScreenFlag.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.GroupIndex != 0)
			{
				num ^= this.GroupIndex.GetHashCode();
			}
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			num ^= this.conditionDetailIds_.GetHashCode();
			if (this.OpenedAt != 0uL)
			{
				num ^= this.OpenedAt.GetHashCode();
			}
			if (this.ClosedAt != 0uL)
			{
				num ^= this.ClosedAt.GetHashCode();
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
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.EventId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EventId);
			}
			if (this.ScreenFlag != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ScreenFlag);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ItemId);
			}
			if (this.GroupIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.GroupIndex);
			}
			if (this.Priority != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.Priority);
			}
			this.conditionDetailIds_.WriteTo(output, MST_EVENT_ITEM_DISPLAY._repeated_conditionDetailIds_codec);
			if (this.OpenedAt != 0uL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				output.WriteRawTag(72);
				output.WriteUInt64(this.ClosedAt);
			}
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.EventId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventId);
			}
			if (this.ScreenFlag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScreenFlag);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.GroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupIndex);
			}
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			num += this.conditionDetailIds_.CalculateSize(MST_EVENT_ITEM_DISPLAY._repeated_conditionDetailIds_codec);
			if (this.OpenedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.OpenedAt);
			}
			if (this.ClosedAt != 0uL)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.ClosedAt);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_ITEM_DISPLAY other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.EventId != 0)
			{
				this.EventId = other.EventId;
			}
			if (other.ScreenFlag != 0)
			{
				this.ScreenFlag = other.ScreenFlag;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.GroupIndex != 0)
			{
				this.GroupIndex = other.GroupIndex;
			}
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			this.conditionDetailIds_.Add(other.conditionDetailIds_);
			if (other.OpenedAt != 0uL)
			{
				this.OpenedAt = other.OpenedAt;
			}
			if (other.ClosedAt != 0uL)
			{
				this.ClosedAt = other.ClosedAt;
			}
		}

        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            uint num;
            while ((num = input.ReadTag()) != 0)
            {
                uint num2 = num;
                switch (num2)
                {
                    case 0x38:
                    case 0x3a:
                        {
                            this.conditionDetailIds_.AddEntriesFrom(input, _repeated_conditionDetailIds_codec);
                            continue;
                        }
                }
                switch (num2)
                {
                    case 8:
                        {
                            this.Id = input.ReadInt32();
                            continue;
                        }
                    case 0x10:
                        {
                            this.EventId = input.ReadInt32();
                            continue;
                        }
                    case 0x18:
                        {
                            this.ScreenFlag = input.ReadInt32();
                            continue;
                        }
                    case 0x20:
                        {
                            this.ItemId = input.ReadInt32();
                            continue;
                        }
                    case 40:
                        {
                            this.GroupIndex = input.ReadInt32();
                            continue;
                        }
                    case 0x30:
                        {
                            this.Priority = input.ReadInt32();
                            continue;
                        }
                    case 0x40:
                        {
                            this.OpenedAt = input.ReadUInt64();
                            continue;
                        }
                    case 0x48:
                        break;

                    default:
                        {
                            input.SkipLastField();
                            continue;
                        }
                }
                this.ClosedAt = input.ReadUInt64();
            }
        }


    }
}
