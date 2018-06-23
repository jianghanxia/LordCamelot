using Google.Protobuf;
using Google.Protobuf.Reflection;
using System;
using System.Diagnostics;

namespace UFramework
{
	public sealed class MST_EVENT_ITEM_DISPLAY_RELEASE : IMessage, IMessage<MST_EVENT_ITEM_DISPLAY_RELEASE>, IEquatable<MST_EVENT_ITEM_DISPLAY_RELEASE>, IDeepCloneable<MST_EVENT_ITEM_DISPLAY_RELEASE>
	{
		public const int IdFieldNumber = 1;

		public const int CondTypeFieldNumber = 2;

		public const int TargetIdFieldNumber = 3;

		private static readonly MessageParser<MST_EVENT_ITEM_DISPLAY_RELEASE> _parser = new MessageParser<MST_EVENT_ITEM_DISPLAY_RELEASE>(() => new MST_EVENT_ITEM_DISPLAY_RELEASE());

		private int id_;

		private int condType_;

		private int targetId_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor => MST_EVENT_ITEM_DISPLAY_RELEASE.Descriptor;

		[DebuggerNonUserCode]
		public static MessageParser<MST_EVENT_ITEM_DISPLAY_RELEASE> Parser => MST_EVENT_ITEM_DISPLAY_RELEASE._parser;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => MstEventItemDisplayReleaseReflection.Descriptor.MessageTypes[0];

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
		public int CondType
		{
			get => this.condType_;
			set
			{
				this.condType_ = value;
			}
		}

		[DebuggerNonUserCode]
		public int TargetId
		{
			get => this.targetId_;
			set
			{
				this.targetId_ = value;
			}
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_RELEASE()
		{
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_RELEASE(MST_EVENT_ITEM_DISPLAY_RELEASE other) : this()
		{
			this.id_ = other.id_;
			this.condType_ = other.condType_;
			this.targetId_ = other.targetId_;
		}

		[DebuggerNonUserCode]
		public MST_EVENT_ITEM_DISPLAY_RELEASE Clone()
		{
			return new MST_EVENT_ITEM_DISPLAY_RELEASE(this);
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MST_EVENT_ITEM_DISPLAY_RELEASE);
		}

		[DebuggerNonUserCode]
		public bool Equals(MST_EVENT_ITEM_DISPLAY_RELEASE other)
		{
			return !object.ReferenceEquals(other, null) && (object.ReferenceEquals(other, this) || (this.Id == other.Id && this.CondType == other.CondType && this.TargetId == other.TargetId));
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.CondType != 0)
			{
				num ^= this.CondType.GetHashCode();
			}
			if (this.TargetId != 0)
			{
				num ^= this.TargetId.GetHashCode();
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
			if (this.CondType != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CondType);
			}
			if (this.TargetId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TargetId);
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
			if (this.CondType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CondType);
			}
			if (this.TargetId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetId);
			}
			return num;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(MST_EVENT_ITEM_DISPLAY_RELEASE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.CondType != 0)
			{
				this.CondType = other.CondType;
			}
			if (other.TargetId != 0)
			{
				this.TargetId = other.TargetId;
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
							this.TargetId = input.ReadInt32();
						}
					}
					else
					{
						this.CondType = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}
	}
}
